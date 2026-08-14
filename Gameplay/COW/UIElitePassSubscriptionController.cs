using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20025F8")]
public class UIElitePassSubscriptionController : UINavigationController, _Attribute
{
	[Token(Token = "0x400EAA1")]
	[FieldOffset(Offset = "0x68")]
	private UIElitePassSubscriptionView m_View;

	[Token(Token = "0x400EAA2")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelElitePass m_Model;

	[Token(Token = "0x400EAA3")]
	[FieldOffset(Offset = "0x0")]
	private static OnFinished _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EAA4")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600E04E")]
	[Address(RVA = "0x3067B34", Offset = "0x3067B34", VA = "0x3067B34")]
	public UIElitePassSubscriptionController()
	{
	}

	[Token(Token = "0x600E04F")]
	[Address(RVA = "0x3067BB8", Offset = "0x3067BB8", VA = "0x3067BB8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E050")]
	[Address(RVA = "0x3067C60", Offset = "0x3067C60", VA = "0x3067C60", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E051")]
	[Address(RVA = "0x30688F4", Offset = "0x30688F4", VA = "0x30688F4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E052")]
	[Address(RVA = "0x30682BC", Offset = "0x30682BC", VA = "0x30682BC")]
	private void UpdateCDNImage()
	{
	}

	[Token(Token = "0x600E053")]
	[Address(RVA = "0x306852C", Offset = "0x306852C", VA = "0x306852C")]
	private void UpdateSubscriptionProductInfo()
	{
	}

	[Token(Token = "0x600E054")]
	[Address(RVA = "0x30686E0", Offset = "0x30686E0", VA = "0x30686E0")]
	private void UpdateSubscriptionBonus()
	{
	}

	[Token(Token = "0x600E055")]
	[Address(RVA = "0x3068BA4", Offset = "0x3068BA4", VA = "0x3068BA4")]
	private void OnSubscribeBtnClick()
	{
	}

	[Token(Token = "0x600E056")]
	[Address(RVA = "0x3068CB4", Offset = "0x3068CB4", VA = "0x3068CB4")]
	private void OnSubscribeTipsBtnClick()
	{
	}

	[Token(Token = "0x600E057")]
	[Address(RVA = "0x3068D94", Offset = "0x3068D94", VA = "0x3068D94", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E058")]
	[Address(RVA = "0x3068E28", Offset = "0x3068E28", VA = "0x3068E28", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E059")]
	[Address(RVA = "0x3068FA0", Offset = "0x3068FA0", VA = "0x3068FA0")]
	private void OnBtnTermsOfServiceClick()
	{
	}

	[Token(Token = "0x600E05A")]
	[Address(RVA = "0x3069068", Offset = "0x3069068", VA = "0x3069068")]
	private void OnBtnPrivacyPolicyClick()
	{
	}

	[Token(Token = "0x600E05B")]
	[Address(RVA = "0x3069130", Offset = "0x3069130", VA = "0x3069130")]
	private static void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600E05C")]
	[Address(RVA = "0x30691D4", Offset = "0x30691D4", VA = "0x30691D4")]
	private static bool _003CUpdateCDNImage_003Em__1(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E05D")]
	[Address(RVA = "0x3069280", Offset = "0x3069280", VA = "0x3069280")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E05E")]
	[Address(RVA = "0x3069288", Offset = "0x3069288", VA = "0x3069288")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
