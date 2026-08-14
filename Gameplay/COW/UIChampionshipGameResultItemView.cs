using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200340F")]
internal class UIChampionshipGameResultItemView : UIBaseView
{
	[Token(Token = "0x4014189")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Rank;

	[Token(Token = "0x401418A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Mode;

	[Token(Token = "0x401418B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Kills;

	[Token(Token = "0x401418C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Score;

	[Token(Token = "0x401418D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Time;

	[Token(Token = "0x6015FE1")]
	[Address(RVA = "0x2829914", Offset = "0x2829914", VA = "0x2829914")]
	public UIChampionshipGameResultItemView()
	{
	}

	[Token(Token = "0x6015FE2")]
	[Address(RVA = "0x282991C", Offset = "0x282991C", VA = "0x282991C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FE3")]
	[Address(RVA = "0x2829B60", Offset = "0x2829B60", VA = "0x2829B60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
