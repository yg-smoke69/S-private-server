using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A2E")]
public class UIPaymentGrowthFundItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010367")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentGrowthFundItemView m_View;

	[Token(Token = "0x4010368")]
	[FieldOffset(Offset = "0x2C")]
	private PayLevelRewardDesc m_Data;

	[Token(Token = "0x4010369")]
	[FieldOffset(Offset = "0x30")]
	private UIModelPayment m_Payment;

	[Token(Token = "0x401036A")]
	[FieldOffset(Offset = "0x34")]
	private PlayLevelInfo m_Info;

	[Token(Token = "0x401036B")]
	[FieldOffset(Offset = "0x38")]
	private Color m_NormalColor;

	[Token(Token = "0x401036C")]
	[FieldOffset(Offset = "0x48")]
	private Color m_DisableColor;

	[Token(Token = "0x601110B")]
	[Address(RVA = "0x29D0480", Offset = "0x29D0480", VA = "0x29D0480")]
	public UIPaymentGrowthFundItemController()
	{
	}

	[Token(Token = "0x601110C")]
	[Address(RVA = "0x29D0504", Offset = "0x29D0504", VA = "0x29D0504")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601110D")]
	[Address(RVA = "0x29D05AC", Offset = "0x29D05AC", VA = "0x29D05AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601110E")]
	[Address(RVA = "0x29D0810", Offset = "0x29D0810", VA = "0x29D0810", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601110F")]
	[Address(RVA = "0x29D0898", Offset = "0x29D0898", VA = "0x29D0898")]
	public EStore.PayLevelInfoState GetPayLevelInfoState()
	{
		return default(EStore.PayLevelInfoState);
	}

	[Token(Token = "0x6011110")]
	[Address(RVA = "0x29D097C", Offset = "0x29D097C", VA = "0x29D097C")]
	public void SetData(PayLevelRewardDesc data)
	{
	}

	[Token(Token = "0x6011111")]
	[Address(RVA = "0x29D117C", Offset = "0x29D117C", VA = "0x29D117C")]
	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
	{
	}

	[Token(Token = "0x6011112")]
	[Address(RVA = "0x29D0A24", Offset = "0x29D0A24", VA = "0x29D0A24")]
	private void UpdateContents()
	{
	}

	[Token(Token = "0x6011113")]
	[Address(RVA = "0x29D1228", Offset = "0x29D1228", VA = "0x29D1228")]
	private void OnClaimClick()
	{
	}

	[Token(Token = "0x6011114")]
	[Address(RVA = "0x29D1688", Offset = "0x29D1688", VA = "0x29D1688", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011115")]
	[Address(RVA = "0x29D1770", Offset = "0x29D1770", VA = "0x29D1770", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011116")]
	[Address(RVA = "0x29D18F0", Offset = "0x29D18F0", VA = "0x29D18F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011117")]
	[Address(RVA = "0x29D18F8", Offset = "0x29D18F8", VA = "0x29D18F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
