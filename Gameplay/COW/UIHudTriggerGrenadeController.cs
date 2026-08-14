using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200288C")]
internal class UIHudTriggerGrenadeController : UIBaseController
{
	[Token(Token = "0x400F9AD")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTriggerGrenadeView m_View;

	[Token(Token = "0x400F9AE")]
	[FieldOffset(Offset = "0x2C")]
	private float m_EndTime;

	[Token(Token = "0x400F9AF")]
	[FieldOffset(Offset = "0x30")]
	private float m_ExplosionTime;

	[Token(Token = "0x400F9B0")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 m_pos;

	[Token(Token = "0x400F9B1")]
	[FieldOffset(Offset = "0x40")]
	private ResourceID m_BeepSoundID;

	[Token(Token = "0x400F9B2")]
	[FieldOffset(Offset = "0x44")]
	private AudioResource m_AudioSource;

	[Token(Token = "0x400F9B3")]
	[FieldOffset(Offset = "0x48")]
	private HJFOGANOHGP m_Grenade;

	[Token(Token = "0x400F9B4")]
	[FieldOffset(Offset = "0x4C")]
	private float m_LastRemainingTime;

	[Token(Token = "0x400F9B5")]
	[FieldOffset(Offset = "0x50")]
	private float m_LastProgress;

	[Token(Token = "0x400F9B6")]
	[FieldOffset(Offset = "0x54")]
	private bool m_EnterDangerTime;

	[Token(Token = "0x600FE74")]
	[Address(RVA = "0x158C2C8", Offset = "0x158C2C8", VA = "0x158C2C8")]
	public UIHudTriggerGrenadeController()
	{
	}

	[Token(Token = "0x600FE75")]
	[Address(RVA = "0x158C358", Offset = "0x158C358", VA = "0x158C358")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FE76")]
	[Address(RVA = "0x158C3FC", Offset = "0x158C3FC", VA = "0x158C3FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FE77")]
	[Address(RVA = "0x158C884", Offset = "0x158C884", VA = "0x158C884", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FE78")]
	[Address(RVA = "0x158C9B8", Offset = "0x158C9B8", VA = "0x158C9B8")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600FE79")]
	[Address(RVA = "0x158CCB4", Offset = "0x158CCB4", VA = "0x158CCB4")]
	private void OnGrenadeTrigger()
	{
	}

	[Token(Token = "0x600FE7A")]
	[Address(RVA = "0x158CF2C", Offset = "0x158CF2C", VA = "0x158CF2C")]
	private void OnChangeVisible(object[] param)
	{
	}

	[Token(Token = "0x600FE7B")]
	[Address(RVA = "0x158D2C8", Offset = "0x158D2C8", VA = "0x158D2C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600FE7C")]
	[Address(RVA = "0x158D840", Offset = "0x158D840", VA = "0x158D840")]
	public float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x600FE7D")]
	[Address(RVA = "0x158C604", Offset = "0x158C604", VA = "0x158C604")]
	private void ResetStatus()
	{
	}

	[Token(Token = "0x600FE7E")]
	[Address(RVA = "0x158D998", Offset = "0x158D998", VA = "0x158D998")]
	private void OnExecute()
	{
	}

	[Token(Token = "0x600FE7F")]
	[Address(RVA = "0x158DA1C", Offset = "0x158DA1C", VA = "0x158DA1C")]
	public void SetDefaultPos(Vector3 pos)
	{
	}

	[Token(Token = "0x600FE80")]
	[Address(RVA = "0x158DAA4", Offset = "0x158DAA4", VA = "0x158DAA4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FE81")]
	[Address(RVA = "0x158DAAC", Offset = "0x158DAAC", VA = "0x158DAAC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
