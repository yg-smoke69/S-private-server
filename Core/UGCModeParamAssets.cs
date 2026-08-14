using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D0")]
public class UGCModeParamAssets : ScriptableObject
{
	[Token(Token = "0x400330E")]
	[FieldOffset(Offset = "0xC")]
	public List<UGCModeParamItem> ModeParams;

	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x26492D8", Offset = "0x26492D8", VA = "0x26492D8")]
	public UGCModeParamAssets()
	{
	}

	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x2649364", Offset = "0x2649364", VA = "0x2649364")]
	public byte[] Export2Bytes()
	{
		return null;
	}
}
