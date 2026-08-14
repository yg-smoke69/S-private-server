using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003E26")]
public class AkGameObjPositionOffsetData
{
	[Token(Token = "0x401A529")]
	[FieldOffset(Offset = "0x8")]
	public bool KeepMe;

	[Token(Token = "0x401A52A")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 positionOffset;

	[Token(Token = "0x6019445")]
	[Address(RVA = "0x35DB770", Offset = "0x35DB770", VA = "0x35DB770")]
	public AkGameObjPositionOffsetData(bool IReallyWantToBeConstructed = false)
	{
	}
}
