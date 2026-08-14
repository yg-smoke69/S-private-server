using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A2B")]
public class PreviewCommon3dRotate : MonoBehaviour
{
	[Token(Token = "0x4005B2E")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 CollectionRotation;

	[Token(Token = "0x4005B2F")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 MallRotation;

	[Token(Token = "0x4005B30")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 GachaRotation;

	[Token(Token = "0x4005B31")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 EpRotation;

	[Token(Token = "0x4005B32")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_Inited;

	[Token(Token = "0x4005B33")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, Vector3> m_PreviewCommon3dRotateDic;

	[Token(Token = "0x1700062A")]
	public Dictionary<int, Vector3> PreviewCommon3dRotateDic
	{
		[Token(Token = "0x6004F68")]
		[Address(RVA = "0x1C19DEC", Offset = "0x1C19DEC", VA = "0x1C19DEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F67")]
	[Address(RVA = "0x1C19D60", Offset = "0x1C19D60", VA = "0x1C19D60")]
	public PreviewCommon3dRotate()
	{
	}
}
