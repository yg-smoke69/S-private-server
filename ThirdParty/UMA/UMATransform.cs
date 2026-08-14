using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CE9")]
public class UMATransform
{
	[Token(Token = "0x2003CEA")]
	public class UMATransformComparer : _Attribute
	{
		[Token(Token = "0x6018609")]
		[Address(RVA = "0x35E9B50", Offset = "0x35E9B50", VA = "0x35E9B50")]
		public UMATransformComparer()
		{
		}

		[Token(Token = "0x601860A")]
		[Address(RVA = "0x35E9B58", Offset = "0x35E9B58", VA = "0x35E9B58", Slot = "4")]
		public int Compare(UMATransform x, UMATransform y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4019DE7")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 position;

	[Token(Token = "0x4019DE8")]
	[FieldOffset(Offset = "0x14")]
	public Quaternion rotation;

	[Token(Token = "0x4019DE9")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 scale;

	[Token(Token = "0x4019DEA")]
	[FieldOffset(Offset = "0x30")]
	public string name;

	[Token(Token = "0x4019DEB")]
	[FieldOffset(Offset = "0x34")]
	public int hash;

	[Token(Token = "0x4019DEC")]
	[FieldOffset(Offset = "0x38")]
	public int parent;

	[Token(Token = "0x4019DED")]
	[FieldOffset(Offset = "0x0")]
	public static UMATransformComparer TransformComparer;

	[Token(Token = "0x6018604")]
	[Address(RVA = "0x35E9AC8", Offset = "0x35E9AC8", VA = "0x35E9AC8")]
	public UMATransform()
	{
	}

	[Token(Token = "0x6018605")]
	[Address(RVA = "0x35E60C8", Offset = "0x35E60C8", VA = "0x35E60C8")]
	public UMATransform(Transform transform, int nameHash, int parentHash)
	{
	}

	[Token(Token = "0x6018606")]
	[Address(RVA = "0x35E65F8", Offset = "0x35E65F8", VA = "0x35E65F8")]
	public UMATransform Duplicate()
	{
		return null;
	}

	[Token(Token = "0x6018607")]
	[Address(RVA = "0x35E9228", Offset = "0x35E9228", VA = "0x35E9228")]
	public void Assign(UMATransform other)
	{
	}
}
