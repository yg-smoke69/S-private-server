using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022C1")]
public class UIPVEGameStartController : UILinkActivityDetailController
{
	[Token(Token = "0x400D93F")]
	[FieldOffset(Offset = "0x34")]
	private UIPVEStartGameView m_View;

	[Token(Token = "0x400D940")]
	[FieldOffset(Offset = "0x38")]
	private List<UIPVEGameStartRewardItemController> m_DailyAwardControllers;

	[Token(Token = "0x400D941")]
	[FieldOffset(Offset = "0x3C")]
	private MapOpeningInfo m_SelectMap;

	[Token(Token = "0x400D942")]
	[FieldOffset(Offset = "0x40")]
	private UIModelPVE m_ModelPVE;

	[Token(Token = "0x600BF44")]
	[Address(RVA = "0x15A306C", Offset = "0x15A306C", VA = "0x15A306C")]
	public UIPVEGameStartController()
	{
	}

	[Token(Token = "0x600BF45")]
	[Address(RVA = "0x15A3074", Offset = "0x15A3074", VA = "0x15A3074")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF46")]
	[Address(RVA = "0x15A311C", Offset = "0x15A311C", VA = "0x15A311C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF47")]
	[Address(RVA = "0x15A3504", Offset = "0x15A3504", VA = "0x15A3504", Slot = "33")]
	protected override void InitActivityInfo()
	{
	}

	[Token(Token = "0x600BF48")]
	[Address(RVA = "0x15A3A60", Offset = "0x15A3A60", VA = "0x15A3A60")]
	private void InitActivityInfo(LinkActivityData data)
	{
	}

	[Token(Token = "0x600BF49")]
	[Address(RVA = "0x15A42E8", Offset = "0x15A42E8", VA = "0x15A42E8")]
	private bool InitRewardId(UISprite icon, uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x600BF4A")]
	[Address(RVA = "0x15A337C", Offset = "0x15A337C", VA = "0x15A337C")]
	private void InitStartMatchUI()
	{
	}

	[Token(Token = "0x600BF4B")]
	[Address(RVA = "0x15A4628", Offset = "0x15A4628", VA = "0x15A4628")]
	private void StartSoloGame()
	{
	}

	[Token(Token = "0x600BF4C")]
	[Address(RVA = "0x15A47D4", Offset = "0x15A47D4", VA = "0x15A47D4")]
	private void StartGroupGame()
	{
	}

	[Token(Token = "0x600BF4D")]
	[Address(RVA = "0x15A4CAC", Offset = "0x15A4CAC", VA = "0x15A4CAC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
