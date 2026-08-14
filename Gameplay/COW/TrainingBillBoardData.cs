using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

namespace COW;

[Token(Token = "0x200024F")]
public class TrainingBillBoardData : _Attribute
{
	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0x8")]
	public string CdnUrl;

	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0xC")]
	public int StartTimeStamp;

	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x10")]
	public int EndTimeStamp;

	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 TextureSize;

	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x232B1D8", Offset = "0x232B1D8", VA = "0x232B1D8")]
	public TrainingBillBoardData()
	{
	}

	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0x232B1E0", Offset = "0x232B1E0", VA = "0x232B1E0", Slot = "4")]
	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}

	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0x232B3A8", Offset = "0x232B3A8", VA = "0x232B3A8")]
	private void loadCfg(JSONNode jObject)
	{
	}
}
