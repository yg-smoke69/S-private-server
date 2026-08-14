using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003948")]
public class UIRebateCardPopupWindowView : UIBaseView
{
	[Token(Token = "0x4017FAC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4017FAD")]
	[FieldOffset(Offset = "0x18")]
	public UIToggle CheckboxForNotify;

	[Token(Token = "0x4017FAE")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel NotifyLabel;

	[Token(Token = "0x4017FAF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LoadingContainer;

	[Token(Token = "0x4017FB0")]
	[FieldOffset(Offset = "0x24")]
	public UISprite RebateCardsContainer_MonthCard;

	[Token(Token = "0x4017FB1")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTextureExt NetworkTexture_MonthCard;

	[Token(Token = "0x4017FB2")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite RebateCardsContainer_WeekCard;

	[Token(Token = "0x4017FB3")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTextureExt NetworkTexture_WeekCard;

	[Token(Token = "0x6016F7F")]
	[Address(RVA = "0x1E42A04", Offset = "0x1E42A04", VA = "0x1E42A04")]
	public UIRebateCardPopupWindowView()
	{
	}

	[Token(Token = "0x6016F80")]
	[Address(RVA = "0x1E42A0C", Offset = "0x1E42A0C", VA = "0x1E42A0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F81")]
	[Address(RVA = "0x1E42E48", Offset = "0x1E42E48", VA = "0x1E42E48")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
