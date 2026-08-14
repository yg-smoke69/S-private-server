using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW;

[Token(Token = "0x2000092")]
public class AvatarTimelineSync : MonoBehaviour
{
	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0xC")]
	private UIMaleAvatar m_LobbyAvatar;

	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x10")]
	private Player m_Owner;

	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x14")]
	private PlayableDirector m_PlayAble;

	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x18")]
	private double m_updatetime;

	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x20")]
	private Animator[] m_Animators;

	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x24")]
	private float m_AniUpdateTime;

	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x28")]
	public DirectorUpdateMode m_PlayUpdateMode;

	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_EnableSync;

	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_SecondEnableSync;

	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x2E")]
	public bool m_UseFraction;

	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x30")]
	public float secondstart;

	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0x34")]
	public float secondend;

	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x38")]
	public bool usemod1;

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x2361480", Offset = "0x2361480", VA = "0x2361480")]
	public AvatarTimelineSync()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x236149C", Offset = "0x236149C", VA = "0x236149C")]
	public void SetPlayer(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x23616B0", Offset = "0x23616B0", VA = "0x23616B0")]
	public void SetTimelineTime(double time)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x23617D4", Offset = "0x23617D4", VA = "0x23617D4")]
	public void SetMaleAvatar(UIMaleAvatar avatar)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x2361A00", Offset = "0x2361A00", VA = "0x2361A00")]
	private void UpdateSecond()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x2361E14", Offset = "0x2361E14", VA = "0x2361E14")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x23625F8", Offset = "0x23625F8", VA = "0x23625F8")]
	public void SetSyncState(bool enable)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x2362658", Offset = "0x2362658", VA = "0x2362658")]
	public void SetSecondSyncState(bool enable)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x23626B8", Offset = "0x23626B8", VA = "0x23626B8")]
	public void SetTimelineSkip()
	{
	}
}
