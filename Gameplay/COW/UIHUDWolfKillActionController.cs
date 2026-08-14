using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C4A")]
internal class UIHUDWolfKillActionController : UIBaseController
{
	[Token(Token = "0x2002C4B")]
	private sealed class _003CPlayKillEffect_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010E43")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject flyEffect;

		[Token(Token = "0x4010E44")]
		[FieldOffset(Offset = "0xC")]
		internal Vector3 targetPos;

		[Token(Token = "0x60127C4")]
		[Address(RVA = "0x1628D88", Offset = "0x1628D88", VA = "0x1628D88")]
		public _003CPlayKillEffect_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60127C5")]
		[Address(RVA = "0x1629108", Offset = "0x1629108", VA = "0x1629108")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010E3F")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDWolfKillActionView m_View;

	[Token(Token = "0x4010E40")]
	[FieldOffset(Offset = "0x30")]
	private IHAAMHPPLMG m_TargetID;

	[Token(Token = "0x4010E41")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsInCD;

	[Token(Token = "0x4010E42")]
	[FieldOffset(Offset = "0x4C")]
	private float m_CDEndTime;

	[Token(Token = "0x60127B0")]
	[Address(RVA = "0x1627054", Offset = "0x1627054", VA = "0x1627054")]
	public UIHUDWolfKillActionController()
	{
	}

	[Token(Token = "0x60127B1")]
	[Address(RVA = "0x1627130", Offset = "0x1627130", VA = "0x1627130")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60127B2")]
	[Address(RVA = "0x16271D8", Offset = "0x16271D8", VA = "0x16271D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60127B3")]
	[Address(RVA = "0x1627438", Offset = "0x1627438", VA = "0x1627438", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60127B4")]
	[Address(RVA = "0x162756C", Offset = "0x162756C", VA = "0x162756C")]
	private void Update()
	{
	}

	[Token(Token = "0x60127B5")]
	[Address(RVA = "0x162775C", Offset = "0x162775C", VA = "0x162775C")]
	private void UpdateValid()
	{
	}

	[Token(Token = "0x60127B6")]
	[Address(RVA = "0x1627DB4", Offset = "0x1627DB4", VA = "0x1627DB4")]
	private void ChooseNewTarget()
	{
	}

	[Token(Token = "0x60127B7")]
	[Address(RVA = "0x1627C24", Offset = "0x1627C24", VA = "0x1627C24")]
	private bool IsPlayerValidTarget(Player player)
	{
		return default(bool);
	}

	[Token(Token = "0x60127B8")]
	[Address(RVA = "0x16281EC", Offset = "0x16281EC", VA = "0x16281EC")]
	private bool CheckInKillRange(Vector3 targetPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60127B9")]
	[Address(RVA = "0x16275D4", Offset = "0x16275D4", VA = "0x16275D4")]
	private void UpdateCD()
	{
	}

	[Token(Token = "0x60127BA")]
	[Address(RVA = "0x16283DC", Offset = "0x16283DC", VA = "0x16283DC")]
	private void StopCD()
	{
	}

	[Token(Token = "0x60127BB")]
	[Address(RVA = "0x1627B8C", Offset = "0x1627B8C", VA = "0x1627B8C")]
	private void OnActionEnable(bool isEnable)
	{
	}

	[Token(Token = "0x60127BC")]
	[Address(RVA = "0x162848C", Offset = "0x162848C", VA = "0x162848C")]
	private void Kill()
	{
	}

	[Token(Token = "0x60127BD")]
	[Address(RVA = "0x162898C", Offset = "0x162898C", VA = "0x162898C")]
	private void PlayKillEffect(Vector3 beginPos, Vector3 targetPos)
	{
	}

	[Token(Token = "0x60127BE")]
	[Address(RVA = "0x1628D90", Offset = "0x1628D90", VA = "0x1628D90")]
	private void OnKillCd(object[] data)
	{
	}

	[Token(Token = "0x60127BF")]
	[Address(RVA = "0x1628EEC", Offset = "0x1628EEC", VA = "0x1628EEC")]
	public Transform GetShowRoot()
	{
		return null;
	}

	[Token(Token = "0x60127C0")]
	[Address(RVA = "0x1628F58", Offset = "0x1628F58", VA = "0x1628F58")]
	public UIButton GetTutorialBtn()
	{
		return null;
	}

	[Token(Token = "0x60127C1")]
	[Address(RVA = "0x1629028", Offset = "0x1629028", VA = "0x1629028")]
	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	[Token(Token = "0x60127C2")]
	[Address(RVA = "0x16290F8", Offset = "0x16290F8", VA = "0x16290F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60127C3")]
	[Address(RVA = "0x1629100", Offset = "0x1629100", VA = "0x1629100")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
