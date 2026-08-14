using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027B6")]
internal class UIHudMatchResultWorkShopPanelController : UIBaseController, _Attribute
{
	[Token(Token = "0x20027B7")]
	private enum EClickedBtn
	{
		[Token(Token = "0x400F523")]
		EDetail,
		[Token(Token = "0x400F524")]
		EComment
	}

	[Token(Token = "0x400F51B")]
	[FieldOffset(Offset = "0x28")]
	private UIHudMatchResultWorkShopPanelView m_View;

	[Token(Token = "0x400F51C")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F51D")]
	[FieldOffset(Offset = "0x30")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x400F51E")]
	[FieldOffset(Offset = "0x34")]
	private Action<bool> m_ReqCallback;

	[Token(Token = "0x400F51F")]
	[FieldOffset(Offset = "0x38")]
	private bool m_CanBeSubscribed;

	[Token(Token = "0x400F520")]
	[FieldOffset(Offset = "0x3C")]
	private SceneEditSlotInfo m_SlotInfo;

	[Token(Token = "0x400F521")]
	[FieldOffset(Offset = "0x40")]
	private EClickedBtn m_ClickedBtn;

	[Token(Token = "0x600F542")]
	[Address(RVA = "0x19C1CB4", Offset = "0x19C1CB4", VA = "0x19C1CB4")]
	public UIHudMatchResultWorkShopPanelController()
	{
	}

	[Token(Token = "0x600F543")]
	[Address(RVA = "0x19C1D38", Offset = "0x19C1D38", VA = "0x19C1D38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F544")]
	[Address(RVA = "0x19C1DE0", Offset = "0x19C1DE0", VA = "0x19C1DE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F545")]
	[Address(RVA = "0x19C26C0", Offset = "0x19C26C0", VA = "0x19C26C0")]
	public void RegistReqCallback(Action<bool> action)
	{
	}

	[Token(Token = "0x600F546")]
	[Address(RVA = "0x19C2720", Offset = "0x19C2720", VA = "0x19C2720")]
	private void RefreshSubState()
	{
	}

	[Token(Token = "0x600F547")]
	[Address(RVA = "0x19C2834", Offset = "0x19C2834", VA = "0x19C2834")]
	public void ShowInfo(bool show)
	{
	}

	[Token(Token = "0x600F548")]
	[Address(RVA = "0x19C29EC", Offset = "0x19C29EC", VA = "0x19C29EC")]
	private void OnWLikeBtnClick()
	{
	}

	[Token(Token = "0x600F549")]
	[Address(RVA = "0x19C2C74", Offset = "0x19C2C74", VA = "0x19C2C74")]
	private void OnWDisLikeBtnClick()
	{
	}

	[Token(Token = "0x600F54A")]
	[Address(RVA = "0x19C2E38", Offset = "0x19C2E38", VA = "0x19C2E38")]
	private void OnWSubBtnClick()
	{
	}

	[Token(Token = "0x600F54B")]
	[Address(RVA = "0x19C317C", Offset = "0x19C317C", VA = "0x19C317C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F54C")]
	[Address(RVA = "0x19C3504", Offset = "0x19C3504", VA = "0x19C3504", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F54D")]
	[Address(RVA = "0x19C3598", Offset = "0x19C3598", VA = "0x19C3598")]
	public void OnMapDetailButtonClick()
	{
	}

	[Token(Token = "0x600F54E")]
	[Address(RVA = "0x19C3778", Offset = "0x19C3778", VA = "0x19C3778")]
	public void OnCommentBtnClick()
	{
	}

	[Token(Token = "0x600F54F")]
	[Address(RVA = "0x19C3354", Offset = "0x19C3354", VA = "0x19C3354")]
	public void ShowCommentInfo()
	{
	}

	[Token(Token = "0x600F550")]
	[Address(RVA = "0x19C3288", Offset = "0x19C3288", VA = "0x19C3288")]
	public void ShowDetailInfo()
	{
	}

	[Token(Token = "0x600F551")]
	[Address(RVA = "0x19C39C4", Offset = "0x19C39C4", VA = "0x19C39C4")]
	private void _003COnWSubBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600F552")]
	[Address(RVA = "0x19C3A40", Offset = "0x19C3A40", VA = "0x19C3A40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
