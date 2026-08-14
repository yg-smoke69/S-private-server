using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FF0")]
public class UIHUDBountyBossInfoController : UIBaseController
{
	[Token(Token = "0x2001FF1")]
	private sealed class _003CDelayHideObject_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C8D3")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject obj;

		[Token(Token = "0x400C8D4")]
		[FieldOffset(Offset = "0xC")]
		internal bool isHide;

		[Token(Token = "0x600A12D")]
		[Address(RVA = "0x167525C", Offset = "0x167525C", VA = "0x167525C")]
		public _003CDelayHideObject_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A12E")]
		[Address(RVA = "0x1675628", Offset = "0x1675628", VA = "0x1675628")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C8D1")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDBountyBOSSInfoView m_View;

	[Token(Token = "0x400C8D2")]
	[FieldOffset(Offset = "0x2C")]
	private Camera m_FollowCameraComponent;

	[Token(Token = "0x600A123")]
	[Address(RVA = "0x16746EC", Offset = "0x16746EC", VA = "0x16746EC")]
	public UIHUDBountyBossInfoController()
	{
	}

	[Token(Token = "0x600A124")]
	[Address(RVA = "0x1674770", Offset = "0x1674770", VA = "0x1674770")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A125")]
	[Address(RVA = "0x1674818", Offset = "0x1674818", VA = "0x1674818", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A126")]
	[Address(RVA = "0x1674ADC", Offset = "0x1674ADC", VA = "0x1674ADC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A127")]
	[Address(RVA = "0x1674C78", Offset = "0x1674C78", VA = "0x1674C78")]
	private void OnPhaseChange(GEvent gEvent)
	{
	}

	[Token(Token = "0x600A128")]
	[Address(RVA = "0x16750B0", Offset = "0x16750B0", VA = "0x16750B0")]
	private void DelayHideObject(GameObject obj, float t, bool isHide = true)
	{
	}

	[Token(Token = "0x600A129")]
	[Address(RVA = "0x1675264", Offset = "0x1675264", VA = "0x1675264")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600A12A")]
	[Address(RVA = "0x1675580", Offset = "0x1675580", VA = "0x1675580")]
	private void OnBossEnhance(object[] param)
	{
	}

	[Token(Token = "0x600A12B")]
	[Address(RVA = "0x1675618", Offset = "0x1675618", VA = "0x1675618")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A12C")]
	[Address(RVA = "0x1675620", Offset = "0x1675620", VA = "0x1675620")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
