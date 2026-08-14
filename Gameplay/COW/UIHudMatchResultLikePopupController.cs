using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027B5")]
internal class UIHudMatchResultLikePopupController : UIBaseController
{
	[Token(Token = "0x400F518")]
	[FieldOffset(Offset = "0x28")]
	private UIHudMatchResultLikePopupView m_View;

	[Token(Token = "0x400F519")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400F51A")]
	[FieldOffset(Offset = "0x30")]
	private Animator m_Animator;

	[Token(Token = "0x600F534")]
	[Address(RVA = "0x19BA680", Offset = "0x19BA680", VA = "0x19BA680")]
	public UIHudMatchResultLikePopupController()
	{
	}

	[Token(Token = "0x600F535")]
	[Address(RVA = "0x19BA704", Offset = "0x19BA704", VA = "0x19BA704")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F536")]
	[Address(RVA = "0x19BA7A8", Offset = "0x19BA7A8", VA = "0x19BA7A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F537")]
	[Address(RVA = "0x19BA880", Offset = "0x19BA880", VA = "0x19BA880", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F538")]
	[Address(RVA = "0x19BA8E4", Offset = "0x19BA8E4", VA = "0x19BA8E4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F539")]
	[Address(RVA = "0x19BAA60", Offset = "0x19BAA60", VA = "0x19BAA60")]
	public void SetMessage(string message, float duration)
	{
	}

	[Token(Token = "0x600F53A")]
	[Address(RVA = "0x19BAE00", Offset = "0x19BAE00", VA = "0x19BAE00")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x600F53B")]
	[Address(RVA = "0x19BAED0", Offset = "0x19BAED0", VA = "0x19BAED0")]
	private void AutoHide()
	{
	}

	[Token(Token = "0x600F53C")]
	[Address(RVA = "0x19BA950", Offset = "0x19BA950", VA = "0x19BA950")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600F53D")]
	[Address(RVA = "0x19BAFE0", Offset = "0x19BAFE0", VA = "0x19BAFE0", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600F53E")]
	[Address(RVA = "0x19BB04C", Offset = "0x19BB04C", VA = "0x19BB04C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F53F")]
	[Address(RVA = "0x19BB054", Offset = "0x19BB054", VA = "0x19BB054")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F540")]
	[Address(RVA = "0x19BB05C", Offset = "0x19BB05C", VA = "0x19BB05C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F541")]
	[Address(RVA = "0x19BB064", Offset = "0x19BB064", VA = "0x19BB064")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
