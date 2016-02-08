using System;

struct Version
{
    int major;
    int minor;
    int build;
    int revision;

    public Version(string version)
    {
        string[] vers = version.Split('.');
        if (vers.Length == 4)
        {
            major = Int32.Parse(vers[0]);
            minor = Int32.Parse(vers[1]);
            build = Int32.Parse(vers[2]);
            revision = Int32.Parse(vers[3]);
        }
        else if (vers.Length == 3)
        {
            major = Int32.Parse(vers[0]);
            minor = Int32.Parse(vers[1]);
            build = Int32.Parse(vers[2]);
            revision = 0;
        }
        else
        {
            major = minor = build = revision = 0;
        }
    }

    public Version(int major, int minor, int build, int revision)
    {
        this.major = major;
        this.minor = minor;
        this.build = build;
        this.revision = revision;
    }

    public override string ToString()
    {
        return major + "." + minor + "." + build + "." + revision;
    }

    public static bool operator ==(Version v1, Version v2)
    {
        if (v1.major == v2.major &&
            v1.minor == v2.minor &&
            v1.build == v2.build &&
            v1.revision == v2.revision)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(Version v1, Version v2)
    {
        return !(v1 == v2);
    }

    public static bool operator <(Version v1, Version v2)
    {
        if (v1.major > v2.major)
            return false;
        if (v1.minor > v2.minor)
            return false;
        if (v1.build > v2.build)
            return false;
        if (v1.revision > v2.revision)
            return false;
        if (v1 == v2)
            return false;
        return true;
    }

    public static bool operator <=(Version v1, Version v2)
    {
        if (v1 == v2 || v1 < v2)
            return true;
        return false;
    }

    public static bool operator >(Version v1, Version v2)
    {
        if (v1.major < v2.major)
            return false;
        if (v1.minor < v2.minor)
            return false;
        if (v1.build < v2.build)
            return false;
        if (v1.revision < v2.revision)
            return false;
        if (v1 == v2)
            return false;
        return true;
    }

    public static bool operator >=(Version v1, Version v2)
    {
        if (v1 == v2 || v1 > v2)
            return true;
        return false;
    }
}