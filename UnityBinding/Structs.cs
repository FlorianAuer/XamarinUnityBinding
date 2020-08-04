using System;
using System.Runtime.InteropServices;

namespace NativeLibrary
{
	[StructLayout(LayoutKind.Sequential)]
	public struct MachHeader
	{
		public uint magic;
		public int cputype;
		public int cpusubtype;
		public uint filetype;
		public uint ncmds;
		public uint sizeofcmds;
		public uint flags;
		public uint reserved;
	}
}