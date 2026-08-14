using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200287D")]
internal class UIHudThumbUpChatBtnController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F981")]
	[FieldOffset(Offset = "0x28")]
	private UIModelMatch m_Model;

	[Token(Token = "0x400F982")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudThumbUpChatBtnView m_View;

	[Token(Token = "0x400F983")]
	[FieldOffset(Offset = "0x30")]
	protected uint m_DelayCallID;

	[Token(Token = "0x400F984")]
	[FieldOffset(Offset = "0x34")]
	private Player m_Killer;

	[Token(Token = "0x400F985")]
	[FieldOffset(Offset = "0x38")]
	private bool m_bIsQuadraKill;

	[Token(Token = "0x400F986")]
	[FieldOffset(Offset = "0x3C")]
	private int m_nQuadraKillThumbTimer;

	[Token(Token = "0x600FDE7")]
	[Address(RVA = "0x157C478", Offset = "0x157C478", VA = "0x157C478")]
	public UIHudThumbUpChatBtnController()
	{
	}

	[Token(Token = "0x600FDE8")]
	[Address(RVA = "0x157C4FC", Offset = "0x157C4FC", VA = "0x157C4FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FDE9")]
	[Address(RVA = "0x157C5A0", Offset = "0x157C5A0", VA = "0x157C5A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FDEA")]
	[Address(RVA = "0x157C818", Offset = "0x157C818", VA = "0x157C818", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600FDEB")]
	[Address(RVA = "0x157C8AC", Offset = "0x157C8AC", VA = "0x157C8AC", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600FDEC")]
	[Address(RVA = "0x157CFC4", Offset = "0x157CFC4", VA = "0x157CFC4")]
	protected void WaitAndHide()
	{
	}

	[Token(Token = "0x600FDED")]
	[Address(RVA = "0x157D0E8", Offset = "0x157D0E8", VA = "0x157D0E8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FDEE")]
	[Address(RVA = "0x157D304", Offset = "0x157D304", VA = "0x157D304", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600FDEF")]
	[Address(RVA = "0x157D368", Offset = "0x157D368", VA = "0x157D368", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FDF0")]
	[Address(RVA = "0x157D3E4", Offset = "0x157D3E4", VA = "0x157D3E4")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x600FDF1")]
	[Address(RVA = "0x157D438", Offset = "0x157D438", VA = "0x157D438")]
	private void OnUIHudThumbUpChatBtnClick()
	{
	}

	[Token(Token = "0x600FDF2")]
	[Address(RVA = "0x157DAE4", Offset = "0x157DAE4", VA = "0x157DAE4")]
	private void OnTweenFinished()
	{
	}

	[Token(Token = "0x600FDF3")]
	[Address(RVA = "0x157DB94", Offset = "0x157DB94", VA = "0x157DB94", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600FDF4")]
	[Address(RVA = "0x157DCE0", Offset = "0x157DCE0", VA = "0x157DCE0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FDF5")]
	[Address(RVA = "0x157DCE8", Offset = "0x157DCE8", VA = "0x157DCE8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FDF6")]
	[Address(RVA = "0x157DCF0", Offset = "0x157DCF0", VA = "0x157DCF0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600FDF7")]
	[Address(RVA = "0x157DCF8", Offset = "0x157DCF8", VA = "0x157DCF8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FDF8")]
	[Address(RVA = "0x157DD00", Offset = "0x157DD00", VA = "0x157DD00")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
