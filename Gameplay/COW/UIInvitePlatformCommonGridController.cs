using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028E6")]
public class UIInvitePlatformCommonGridController : UIBaseController
{
	[Token(Token = "0x400FB89")]
	[FieldOffset(Offset = "0x28")]
	private UIInvitePlatformCommonGridView m_View;

	[Token(Token = "0x400FB8A")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelShare m_ModelShare;

	[Token(Token = "0x400FB8B")]
	[FieldOffset(Offset = "0x30")]
	private UIUtils.ShareUrlType m_ShareUrlType;

	[Token(Token = "0x400FB8C")]
	[FieldOffset(Offset = "0x34")]
	private object[] m_Data;

	[Token(Token = "0x6010268")]
	[Address(RVA = "0x1ADA708", Offset = "0x1ADA708", VA = "0x1ADA708")]
	public UIInvitePlatformCommonGridController()
	{
	}

	[Token(Token = "0x6010269")]
	[Address(RVA = "0x1ADA78C", Offset = "0x1ADA78C", VA = "0x1ADA78C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601026A")]
	[Address(RVA = "0x1ADA834", Offset = "0x1ADA834", VA = "0x1ADA834")]
	internal void SetViewData(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
	}

	[Token(Token = "0x601026B")]
	[Address(RVA = "0x1ADA994", Offset = "0x1ADA994", VA = "0x1ADA994")]
	public void SetBtnCopyVisible(bool visible)
	{
	}

	[Token(Token = "0x601026C")]
	[Address(RVA = "0x1ADAAE4", Offset = "0x1ADAAE4", VA = "0x1ADAAE4")]
	public void SetBtnOtherVisible(bool visible)
	{
	}

	[Token(Token = "0x601026D")]
	[Address(RVA = "0x1ADAC34", Offset = "0x1ADAC34", VA = "0x1ADAC34")]
	public void SetGridPivot(Pivot pivot)
	{
	}

	[Token(Token = "0x601026E")]
	[Address(RVA = "0x1ADACC0", Offset = "0x1ADACC0", VA = "0x1ADACC0")]
	public void SetGridWidth(float width)
	{
	}

	[Token(Token = "0x601026F")]
	[Address(RVA = "0x1ADAD5C", Offset = "0x1ADAD5C", VA = "0x1ADAD5C")]
	public UIGrid GetBtnContainerGrid()
	{
		return null;
	}

	[Token(Token = "0x6010270")]
	[Address(RVA = "0x1ADADCC", Offset = "0x1ADADCC", VA = "0x1ADADCC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010271")]
	[Address(RVA = "0x1ADB524", Offset = "0x1ADB524", VA = "0x1ADB524", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010272")]
	[Address(RVA = "0x1ADAEFC", Offset = "0x1ADAEFC", VA = "0x1ADAEFC")]
	private void AddClicks()
	{
	}

	[Token(Token = "0x6010273")]
	[Address(RVA = "0x1ADB580", Offset = "0x1ADB580", VA = "0x1ADB580")]
	private void OnBtnLineInviteClick()
	{
	}

	[Token(Token = "0x6010274")]
	[Address(RVA = "0x1ADB608", Offset = "0x1ADB608", VA = "0x1ADB608")]
	private void OnBtnBindInviteClick()
	{
	}

	[Token(Token = "0x6010275")]
	[Address(RVA = "0x1ADB690", Offset = "0x1ADB690", VA = "0x1ADB690")]
	private void OnBtnOtherInviteClick()
	{
	}

	[Token(Token = "0x6010276")]
	[Address(RVA = "0x1ADB718", Offset = "0x1ADB718", VA = "0x1ADB718")]
	private void OnBtnCopyInviteClick()
	{
	}

	[Token(Token = "0x6010277")]
	[Address(RVA = "0x1ADB18C", Offset = "0x1ADB18C", VA = "0x1ADB18C")]
	private void ShowDynamicContent()
	{
	}

	[Token(Token = "0x6010278")]
	[Address(RVA = "0x1ADB798", Offset = "0x1ADB798", VA = "0x1ADB798")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010279")]
	[Address(RVA = "0x1ADB7A0", Offset = "0x1ADB7A0", VA = "0x1ADB7A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
