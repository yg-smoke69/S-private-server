using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001ED1")]
internal class UIDigitaluniverseBLobbyEggController : UIBaseController, _Attribute
{
	[Token(Token = "0x400C210")]
	[FieldOffset(Offset = "0x28")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C211")]
	[FieldOffset(Offset = "0x2C")]
	private UIDigitaluniverseBLobbyEggView m_View;

	[Token(Token = "0x400C212")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_AccountId;

	[Token(Token = "0x400C213")]
	[FieldOffset(Offset = "0x38")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400C214")]
	[FieldOffset(Offset = "0x3C")]
	private Transform m_Bgvfx;

	[Token(Token = "0x60095EF")]
	[Address(RVA = "0x2F67784", Offset = "0x2F67784", VA = "0x2F67784")]
	public UIDigitaluniverseBLobbyEggController()
	{
	}

	[Token(Token = "0x60095F0")]
	[Address(RVA = "0x2F67898", Offset = "0x2F67898", VA = "0x2F67898")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60095F1")]
	[Address(RVA = "0x2F67940", Offset = "0x2F67940", VA = "0x2F67940", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60095F2")]
	[Address(RVA = "0x2F67C38", Offset = "0x2F67C38", VA = "0x2F67C38")]
	private void Update()
	{
	}

	[Token(Token = "0x60095F3")]
	[Address(RVA = "0x2F67C8C", Offset = "0x2F67C8C", VA = "0x2F67C8C")]
	private ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60095F4")]
	[Address(RVA = "0x2F67CE4", Offset = "0x2F67CE4", VA = "0x2F67CE4")]
	private void GotoBigEvent()
	{
	}

	[Token(Token = "0x60095F5")]
	[Address(RVA = "0x2F67E78", Offset = "0x2F67E78", VA = "0x2F67E78")]
	private void OnClickHdEgg(object[] param)
	{
	}

	[Token(Token = "0x60095F6")]
	[Address(RVA = "0x2F67EE0", Offset = "0x2F67EE0", VA = "0x2F67EE0")]
	private void OnClickEgg()
	{
	}

	[Token(Token = "0x60095F7")]
	[Address(RVA = "0x2F682E4", Offset = "0x2F682E4", VA = "0x2F682E4")]
	private void ShowEggVFX()
	{
	}

	[Token(Token = "0x60095F8")]
	[Address(RVA = "0x2F6877C", Offset = "0x2F6877C", VA = "0x2F6877C")]
	public void ShowLobbyEgg()
	{
	}

	[Token(Token = "0x60095F9")]
	[Address(RVA = "0x2F68B24", Offset = "0x2F68B24", VA = "0x2F68B24", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60095FA")]
	[Address(RVA = "0x2F68BB8", Offset = "0x2F68BB8", VA = "0x2F68BB8", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60095FB")]
	[Address(RVA = "0x2F68C6C", Offset = "0x2F68C6C", VA = "0x2F68C6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
