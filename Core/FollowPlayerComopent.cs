using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005C2")]
public class FollowPlayerComopent : MonoBehaviour
{
	[Token(Token = "0x40043C1")]
	[FieldOffset(Offset = "0xC")]
	public float m_FollowSpeed;

	[Token(Token = "0x40043C2")]
	[FieldOffset(Offset = "0x10")]
	private IHAAMHPPLMG m_FollowPlayerID;

	[Token(Token = "0x40043C3")]
	[FieldOffset(Offset = "0x28")]
	private ResourceID m_ResID;

	[Token(Token = "0x40043C4")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsDestroy;

	[Token(Token = "0x40043C5")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_CachTransform;

	[Token(Token = "0x40043C6")]
	[FieldOffset(Offset = "0x34")]
	private ResourceID m_PickEffectResID;

	[Token(Token = "0x40043C7")]
	[FieldOffset(Offset = "0x38")]
	private ResourceID m_PickSoundResID;

	[Token(Token = "0x60022E8")]
	[Address(RVA = "0x26AEF18", Offset = "0x26AEF18", VA = "0x26AEF18")]
	public FollowPlayerComopent()
	{
	}

	[Token(Token = "0x60022E9")]
	[Address(RVA = "0x26AEFDC", Offset = "0x26AEFDC", VA = "0x26AEFDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60022EA")]
	[Address(RVA = "0x26AEFF8", Offset = "0x26AEFF8", VA = "0x26AEFF8")]
	public void InitComopnent(IHAAMHPPLMG playerId, ResourceID resID, ResourceID pickEffectResID, ResourceID pickSoundResID)
	{
	}

	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x26AF050", Offset = "0x26AF050", VA = "0x26AF050")]
	private void Update()
	{
	}

	[Token(Token = "0x60022EC")]
	[Address(RVA = "0x26AF500", Offset = "0x26AF500", VA = "0x26AF500")]
	private void OnGetClosePlayer(Player player)
	{
	}

	[Token(Token = "0x60022ED")]
	[Address(RVA = "0x26AF374", Offset = "0x26AF374", VA = "0x26AF374")]
	private void RecyleOrDestroy()
	{
	}
}
