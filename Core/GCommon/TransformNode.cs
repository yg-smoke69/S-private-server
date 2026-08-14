using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003ED9")]
public class TransformNode : _Attribute
{
	[Token(Token = "0x401A882")]
	[FieldOffset(Offset = "0x8")]
	private Transform _003Ctransform_003Ek__BackingField;

	[Token(Token = "0x17001BF1")]
	public Transform transform
	{
		[Token(Token = "0x6019956")]
		[Address(RVA = "0x3242D80", Offset = "0x3242D80", VA = "0x3242D80", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019957")]
		[Address(RVA = "0x3242D78", Offset = "0x3242D78", VA = "0x3242D78")]
		private set
		{
		}
	}

	[Token(Token = "0x6019955")]
	[Address(RVA = "0x3242D58", Offset = "0x3242D58", VA = "0x3242D58")]
	public TransformNode(Transform n)
	{
	}
}
