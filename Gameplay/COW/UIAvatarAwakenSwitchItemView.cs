using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FB3")]
public class UIAvatarAwakenSwitchItemView : MonoBehaviour
{
	[Token(Token = "0x400C6DB")]
	[FieldOffset(Offset = "0xC")]
	public UISprite m_AvatarIcon;

	[Token(Token = "0x400C6DC")]
	[FieldOffset(Offset = "0x10")]
	public UISprite m_HL;

	[Token(Token = "0x400C6DD")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_Lock;

	[Token(Token = "0x6009E6F")]
	[Address(RVA = "0x1E860C8", Offset = "0x1E860C8", VA = "0x1E860C8")]
	public UIAvatarAwakenSwitchItemView()
	{
	}

	[Token(Token = "0x6009E70")]
	[Address(RVA = "0x1E860D0", Offset = "0x1E860D0", VA = "0x1E860D0")]
	public void SetView(uint avatarId, ResourceID res)
	{
	}

	[Token(Token = "0x6009E71")]
	[Address(RVA = "0x1E861D0", Offset = "0x1E861D0", VA = "0x1E861D0")]
	public void SetHL(bool show)
	{
	}

	[Token(Token = "0x6009E72")]
	[Address(RVA = "0x1E86274", Offset = "0x1E86274", VA = "0x1E86274")]
	public bool GetHLState()
	{
		return default(bool);
	}

	[Token(Token = "0x6009E73")]
	[Address(RVA = "0x1E8630C", Offset = "0x1E8630C", VA = "0x1E8630C")]
	public void SetLock(bool _lock)
	{
	}
}
