using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200247C")]
public class UIHUDUGC_TimeTweenTipsController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E259")]
	[FieldOffset(Offset = "0x28")]
	private TimeTweenTipsHudEntity m_ViewData;

	[Token(Token = "0x400E25A")]
	[FieldOffset(Offset = "0x2C")]
	private string m_EntityID;

	[Token(Token = "0x400E25B")]
	[FieldOffset(Offset = "0x30")]
	private string m_Description;

	[Token(Token = "0x400E25C")]
	[FieldOffset(Offset = "0x34")]
	private int lastLeftTimeS;

	[Token(Token = "0x400E25D")]
	[FieldOffset(Offset = "0x38")]
	private int EndTimeS;

	[Token(Token = "0x400E25E")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_ShowCD;

	[Token(Token = "0x400E25F")]
	[FieldOffset(Offset = "0x40")]
	private UIHudCommonPregameTimeTipView m_View;

	[Token(Token = "0x600D007")]
	[Address(RVA = "0x29243F0", Offset = "0x29243F0", VA = "0x29243F0")]
	public UIHUDUGC_TimeTweenTipsController()
	{
	}

	[Token(Token = "0x600D008")]
	[Address(RVA = "0x292447C", Offset = "0x292447C", VA = "0x292447C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D009")]
	[Address(RVA = "0x2924524", Offset = "0x2924524", VA = "0x2924524", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D00A")]
	[Address(RVA = "0x29245E0", Offset = "0x29245E0", VA = "0x29245E0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D00B")]
	[Address(RVA = "0x29246C0", Offset = "0x29246C0", VA = "0x29246C0", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D00C")]
	[Address(RVA = "0x292464C", Offset = "0x292464C", VA = "0x292464C", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600D00D")]
	[Address(RVA = "0x29248F4", Offset = "0x29248F4", VA = "0x29248F4")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D00E")]
	[Address(RVA = "0x292497C", Offset = "0x292497C", VA = "0x292497C")]
	private void Update()
	{
	}

	[Token(Token = "0x600D00F")]
	[Address(RVA = "0x2924E44", Offset = "0x2924E44", VA = "0x2924E44")]
	private void OnDescriptionChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600D010")]
	[Address(RVA = "0x2924EB4", Offset = "0x2924EB4", VA = "0x2924EB4")]
	private void OnBaseTimeSChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D011")]
	[Address(RVA = "0x2924F5C", Offset = "0x2924F5C", VA = "0x2924F5C")]
	private void OnDurationtimeSChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D012")]
	[Address(RVA = "0x2925004", Offset = "0x2925004", VA = "0x2925004")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D013")]
	[Address(RVA = "0x292500C", Offset = "0x292500C", VA = "0x292500C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
