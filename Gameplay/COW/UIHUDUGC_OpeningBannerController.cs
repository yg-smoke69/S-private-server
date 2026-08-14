using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002469")]
public class UIHUDUGC_OpeningBannerController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E212")]
	[FieldOffset(Offset = "0x28")]
	private string m_EntityID;

	[Token(Token = "0x400E213")]
	[FieldOffset(Offset = "0x2C")]
	private UIHUDUGC_OpeningBannerView m_View;

	[Token(Token = "0x400E214")]
	[FieldOffset(Offset = "0x30")]
	private OpeningBannerHudEntity m_ViewData;

	[Token(Token = "0x600CF2E")]
	[Address(RVA = "0x2E20D78", Offset = "0x2E20D78", VA = "0x2E20D78")]
	public UIHUDUGC_OpeningBannerController()
	{
	}

	[Token(Token = "0x600CF2F")]
	[Address(RVA = "0x2E20DFC", Offset = "0x2E20DFC", VA = "0x2E20DFC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF30")]
	[Address(RVA = "0x2E20EA0", Offset = "0x2E20EA0", VA = "0x2E20EA0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF31")]
	[Address(RVA = "0x2E20F5C", Offset = "0x2E20F5C", VA = "0x2E20F5C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CF32")]
	[Address(RVA = "0x2E21048", Offset = "0x2E21048", VA = "0x2E21048", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF33")]
	[Address(RVA = "0x2E20FC8", Offset = "0x2E20FC8", VA = "0x2E20FC8", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF34")]
	[Address(RVA = "0x2E217A4", Offset = "0x2E217A4", VA = "0x2E217A4")]
	private string GetLocText(string value)
	{
		return null;
	}

	[Token(Token = "0x600CF35")]
	[Address(RVA = "0x2E218F4", Offset = "0x2E218F4", VA = "0x2E218F4")]
	private bool IsBlack(Color c)
	{
		return default(bool);
	}

	[Token(Token = "0x600CF36")]
	[Address(RVA = "0x2E219F4", Offset = "0x2E219F4", VA = "0x2E219F4")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CF37")]
	[Address(RVA = "0x2E21398", Offset = "0x2E21398", VA = "0x2E21398")]
	private void OnIconSpriteNameChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CF38")]
	[Address(RVA = "0x2E21448", Offset = "0x2E21448", VA = "0x2E21448")]
	private void OnThemeColorChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF39")]
	[Address(RVA = "0x2E21624", Offset = "0x2E21624", VA = "0x2E21624")]
	private void OnTitleTextChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CF3A")]
	[Address(RVA = "0x2E216E4", Offset = "0x2E216E4", VA = "0x2E216E4")]
	private void OnDescTextChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CF3B")]
	[Address(RVA = "0x2E21A7C", Offset = "0x2E21A7C", VA = "0x2E21A7C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CF3C")]
	[Address(RVA = "0x2E21A84", Offset = "0x2E21A84", VA = "0x2E21A84")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
