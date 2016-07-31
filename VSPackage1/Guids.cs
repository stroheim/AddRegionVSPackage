// Guids.cs
// MUST match guids.h
using System;

namespace Company.VSPackage1
{
    static class GuidList
    {
        public const string guidVSPackage1PkgString = "766c0aa5-4043-4901-a5a2-cb32de076b36";
        public const string guidVSPackage1CmdSetString = "50ca1eed-5ba3-4c20-b663-04e92e0c1005";

        public static readonly Guid guidVSPackage1CmdSet = new Guid(guidVSPackage1CmdSetString);
    };
}