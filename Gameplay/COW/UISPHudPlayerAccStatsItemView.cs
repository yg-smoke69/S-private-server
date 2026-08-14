using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039C8")]
internal class UISPHudPlayerAccStatsItemView : MonoBehaviour
{
	[Token(Token = "0x40184EB")]
	[FieldOffset(Offset = "0xC")]
	public UILabel KEY;

	[Token(Token = "0x40184EC")]
	[FieldOffset(Offset = "0x10")]
	public UILabel Value;

	[Token(Token = "0x40184ED")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Rank;

	[Token(Token = "0x40184EE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject No1Obj;

	[Token(Token = "0x40184EF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject No2Obj;

	[Token(Token = "0x40184F0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject No3Obj;

	[Token(Token = "0x60170FF")]
	[Address(RVA = "0x1D26118", Offset = "0x1D26118", VA = "0x1D26118")]
	public UISPHudPlayerAccStatsItemView()
	{
	}

	[Token(Token = "0x6017100")]
	[Address(RVA = "0x1D26120", Offset = "0x1D26120", VA = "0x1D26120")]
	public void SetUI(string data, byte rank, string loc)
	{
	}
}
