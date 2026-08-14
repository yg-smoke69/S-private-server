using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200247D")]
public class UIHUDUGC_TweenTipsController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E260")]
	[FieldOffset(Offset = "0x28")]
	private TweenTipsHudEntity m_ViewData;

	[Token(Token = "0x400E261")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400E262")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x400E263")]
	[FieldOffset(Offset = "0x34")]
	private int m_EventType;

	[Token(Token = "0x400E264")]
	[FieldOffset(Offset = "0x38")]
	private string m_Description;

	[Token(Token = "0x600D014")]
	[Address(RVA = "0x2925014", Offset = "0x2925014", VA = "0x2925014")]
	public UIHUDUGC_TweenTipsController()
	{
	}

	[Token(Token = "0x600D015")]
	[Address(RVA = "0x2925098", Offset = "0x2925098", VA = "0x2925098")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D016")]
	[Address(RVA = "0x2925168", Offset = "0x2925168", VA = "0x2925168", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D017")]
	[Address(RVA = "0x29251CC", Offset = "0x29251CC", VA = "0x29251CC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D018")]
	[Address(RVA = "0x29252B4", Offset = "0x29252B4", VA = "0x29252B4", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D019")]
	[Address(RVA = "0x2925240", Offset = "0x2925240", VA = "0x2925240", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600D01A")]
	[Address(RVA = "0x292548C", Offset = "0x292548C", VA = "0x292548C")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D01B")]
	[Address(RVA = "0x2925514", Offset = "0x2925514", VA = "0x2925514")]
	private void OnEventTipsTypeChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D01C")]
	[Address(RVA = "0x2925590", Offset = "0x2925590", VA = "0x2925590")]
	private void OnDescriptionChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600D01D")]
	[Address(RVA = "0x2925990", Offset = "0x2925990", VA = "0x2925990")]
	private void OnParamChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600D01E")]
	[Address(RVA = "0x2925AB4", Offset = "0x2925AB4", VA = "0x2925AB4")]
	private void ShowTweenTips()
	{
	}

	[Token(Token = "0x600D01F")]
	[Address(RVA = "0x2925F44", Offset = "0x2925F44", VA = "0x2925F44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D020")]
	[Address(RVA = "0x2925F4C", Offset = "0x2925F4C", VA = "0x2925F4C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
