using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200289C")]
internal class UIHUDUGC_ZombieVFXController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FA04")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_ZombieVFXView m_View;

	[Token(Token = "0x400FA05")]
	[FieldOffset(Offset = "0x2C")]
	private ZombieVFXHudEntity m_ViewData;

	[Token(Token = "0x400FA06")]
	[FieldOffset(Offset = "0x30")]
	private CommonParticleEffect m_Effect;

	[Token(Token = "0x400FA07")]
	[FieldOffset(Offset = "0x34")]
	private Object m_EffectObj;

	[Token(Token = "0x600FEF9")]
	[Address(RVA = "0x2933694", Offset = "0x2933694", VA = "0x2933694")]
	public UIHUDUGC_ZombieVFXController()
	{
	}

	[Token(Token = "0x600FEFA")]
	[Address(RVA = "0x2933718", Offset = "0x2933718", VA = "0x2933718")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FEFB")]
	[Address(RVA = "0x29337C0", Offset = "0x29337C0", VA = "0x29337C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FEFC")]
	[Address(RVA = "0x293387C", Offset = "0x293387C", VA = "0x293387C", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600FEFD")]
	[Address(RVA = "0x2933998", Offset = "0x2933998", VA = "0x2933998", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600FEFE")]
	[Address(RVA = "0x2933A0C", Offset = "0x2933A0C", VA = "0x2933A0C")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600FEFF")]
	[Address(RVA = "0x2933E54", Offset = "0x2933E54", VA = "0x2933E54")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
