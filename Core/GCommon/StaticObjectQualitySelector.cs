using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EE0")]
public class StaticObjectQualitySelector : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003EE1")]
	public class DynamicObject
	{
		[Token(Token = "0x401A89E")]
		[FieldOffset(Offset = "0x8")]
		public string resID;

		[Token(Token = "0x401A89F")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 position;

		[Token(Token = "0x401A8A0")]
		[FieldOffset(Offset = "0x18")]
		public Quaternion rotation;

		[Token(Token = "0x401A8A1")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 scale;

		[Token(Token = "0x60199B9")]
		[Address(RVA = "0x32389D4", Offset = "0x32389D4", VA = "0x32389D4")]
		public DynamicObject()
		{
		}
	}

	[Token(Token = "0x401A89D")]
	[FieldOffset(Offset = "0xC")]
	public List<DynamicObject> objList;

	[Token(Token = "0x60199B7")]
	[Address(RVA = "0x3238540", Offset = "0x3238540", VA = "0x3238540")]
	public StaticObjectQualitySelector()
	{
	}

	[Token(Token = "0x60199B8")]
	[Address(RVA = "0x32385CC", Offset = "0x32385CC", VA = "0x32385CC")]
	private void Start()
	{
	}
}
