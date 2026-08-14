using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026B2")]
public class UIGitfGetRewardController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400EEC6")]
	[FieldOffset(Offset = "0x48")]
	private UIGiftGetRewardView m_View;

	[Token(Token = "0x400EEC7")]
	[FieldOffset(Offset = "0x4C")]
	private RewardBtn m_BtnData;

	[Token(Token = "0x600E942")]
	[Address(RVA = "0x1CF4AE8", Offset = "0x1CF4AE8", VA = "0x1CF4AE8")]
	public UIGitfGetRewardController()
	{
	}

	[Token(Token = "0x600E943")]
	[Address(RVA = "0x1CF4AF0", Offset = "0x1CF4AF0", VA = "0x1CF4AF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E944")]
	[Address(RVA = "0x1CF4B98", Offset = "0x1CF4B98", VA = "0x1CF4B98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E945")]
	[Address(RVA = "0x1CF4F10", Offset = "0x1CF4F10", VA = "0x1CF4F10", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E946")]
	[Address(RVA = "0x1CF50D4", Offset = "0x1CF50D4", VA = "0x1CF50D4")]
	private void ProcessAnimEvent(object[] data)
	{
	}

	[Token(Token = "0x600E947")]
	[Address(RVA = "0x1CF5240", Offset = "0x1CF5240", VA = "0x1CF5240")]
	private void ShowContainer()
	{
	}

	[Token(Token = "0x600E948")]
	[Address(RVA = "0x1CF52CC", Offset = "0x1CF52CC", VA = "0x1CF52CC")]
	public void ShowGiftMessage(GiftRewardPopupData info)
	{
	}

	[Token(Token = "0x600E949")]
	[Address(RVA = "0x1CF5734", Offset = "0x1CF5734", VA = "0x1CF5734")]
	private void OnOKBtnClick()
	{
	}

	[Token(Token = "0x600E94A")]
	[Address(RVA = "0x1CF57AC", Offset = "0x1CF57AC", VA = "0x1CF57AC")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600E94B")]
	[Address(RVA = "0x1CF5810", Offset = "0x1CF5810", VA = "0x1CF5810", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E94C")]
	[Address(RVA = "0x1CF5928", Offset = "0x1CF5928", VA = "0x1CF5928", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E94D")]
	[Address(RVA = "0x1CF5C2C", Offset = "0x1CF5C2C", VA = "0x1CF5C2C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E94E")]
	[Address(RVA = "0x1CF5CC0", Offset = "0x1CF5CC0", VA = "0x1CF5CC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E94F")]
	[Address(RVA = "0x1CF5CC8", Offset = "0x1CF5CC8", VA = "0x1CF5CC8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600E950")]
	[Address(RVA = "0x1CF5CD0", Offset = "0x1CF5CD0", VA = "0x1CF5CD0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
