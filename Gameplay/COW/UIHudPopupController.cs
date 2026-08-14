using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200280E")]
internal class UIHudPopupController : UIBaseController
{
	[Token(Token = "0x400F735")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPopupView m_View;

	[Token(Token = "0x400F736")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400F737")]
	[FieldOffset(Offset = "0x30")]
	private Animator m_Animator;

	[Token(Token = "0x600F944")]
	[Address(RVA = "0x1FB9448", Offset = "0x1FB9448", VA = "0x1FB9448")]
	public UIHudPopupController()
	{
	}

	[Token(Token = "0x600F945")]
	[Address(RVA = "0x1FB94CC", Offset = "0x1FB94CC", VA = "0x1FB94CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F946")]
	[Address(RVA = "0x1FB9570", Offset = "0x1FB9570", VA = "0x1FB9570", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F947")]
	[Address(RVA = "0x1FB9648", Offset = "0x1FB9648", VA = "0x1FB9648", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F948")]
	[Address(RVA = "0x1FB96AC", Offset = "0x1FB96AC", VA = "0x1FB96AC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F949")]
	[Address(RVA = "0x1FB9828", Offset = "0x1FB9828", VA = "0x1FB9828")]
	public void SetMessage(string message, float duration)
	{
	}

	[Token(Token = "0x600F94A")]
	[Address(RVA = "0x1FB9B34", Offset = "0x1FB9B34", VA = "0x1FB9B34")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x600F94B")]
	[Address(RVA = "0x1FB9C04", Offset = "0x1FB9C04", VA = "0x1FB9C04")]
	private void AutoHide()
	{
	}

	[Token(Token = "0x600F94C")]
	[Address(RVA = "0x1FB9718", Offset = "0x1FB9718", VA = "0x1FB9718")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600F94D")]
	[Address(RVA = "0x1FB9D14", Offset = "0x1FB9D14", VA = "0x1FB9D14", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600F94E")]
	[Address(RVA = "0x1FB9D80", Offset = "0x1FB9D80", VA = "0x1FB9D80")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F94F")]
	[Address(RVA = "0x1FB9D88", Offset = "0x1FB9D88", VA = "0x1FB9D88")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F950")]
	[Address(RVA = "0x1FB9D90", Offset = "0x1FB9D90", VA = "0x1FB9D90")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F951")]
	[Address(RVA = "0x1FB9D98", Offset = "0x1FB9D98", VA = "0x1FB9D98")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
