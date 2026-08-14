using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200411C")]
public class UI3DObjectHelper : MonoBehaviour
{
	[Token(Token = "0x401B595")]
	[FieldOffset(Offset = "0xC")]
	public Transform[] RegistedObjects;

	[Token(Token = "0x401B596")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Transform> m_RegistedObjectDict;

	[Token(Token = "0x17001D4B")]
	public Dictionary<string, Transform> RegistedObjectDict
	{
		[Token(Token = "0x601A962")]
		[Address(RVA = "0x2C91D54", Offset = "0x2C91D54", VA = "0x2C91D54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A961")]
	[Address(RVA = "0x2C91CC8", Offset = "0x2C91CC8", VA = "0x2C91CC8")]
	public UI3DObjectHelper()
	{
	}

	[Token(Token = "0x601A963")]
	[Address(RVA = "0x2C92004", Offset = "0x2C92004", VA = "0x2C92004")]
	private void Awake()
	{
	}

	[Token(Token = "0x601A964")]
	[Address(RVA = "0x2C91E04", Offset = "0x2C91E04", VA = "0x2C91E04")]
	private void RefreshRegistedObjectDict()
	{
	}

	[Token(Token = "0x601A965")]
	[Address(RVA = "0x2C92008", Offset = "0x2C92008", VA = "0x2C92008")]
	public Transform GetRegistedObjectWithName(string name)
	{
		return null;
	}
}
