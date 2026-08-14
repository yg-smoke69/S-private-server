using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CE2")]
public class TeammateVoiceView : MonoBehaviour
{
	[Token(Token = "0x40111FF")]
	[FieldOffset(Offset = "0xC")]
	public UILabel IndexLabel;

	[Token(Token = "0x4011200")]
	[FieldOffset(Offset = "0x10")]
	public UILabel NameLabel;

	[Token(Token = "0x4011201")]
	[FieldOffset(Offset = "0x14")]
	public UIButton MuteToggleBtn;

	[Token(Token = "0x4011202")]
	[FieldOffset(Offset = "0x18")]
	public UISprite MutedSprite;

	[Token(Token = "0x4011203")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite NotMuteSprite;

	[Token(Token = "0x4011204")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ReportBtn;

	[Token(Token = "0x4011205")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 ViewSize;

	[Token(Token = "0x4011206")]
	[FieldOffset(Offset = "0x2C")]
	private string Bind_UserID;

	[Token(Token = "0x4011207")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_UserID;

	[Token(Token = "0x4011208")]
	[FieldOffset(Offset = "0x38")]
	private IHAAMHPPLMG m_PlayerID;

	[Token(Token = "0x4011209")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsMute;

	[Token(Token = "0x17001352")]
	public bool IsMute
	{
		[Token(Token = "0x6012C87")]
		[Address(RVA = "0x28A259C", Offset = "0x28A259C", VA = "0x28A259C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6012C88")]
		[Address(RVA = "0x28A25F4", Offset = "0x28A25F4", VA = "0x28A25F4")]
		set
		{
		}
	}

	[Token(Token = "0x6012C86")]
	[Address(RVA = "0x28A24FC", Offset = "0x28A24FC", VA = "0x28A24FC")]
	public TeammateVoiceView()
	{
	}

	[Token(Token = "0x6012C89")]
	[Address(RVA = "0x28A2654", Offset = "0x28A2654", VA = "0x28A2654")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012C8A")]
	[Address(RVA = "0x28A2928", Offset = "0x28A2928", VA = "0x28A2928")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6012C8B")]
	[Address(RVA = "0x28A2B10", Offset = "0x28A2B10", VA = "0x28A2B10")]
	public void SetMute(bool isMute)
	{
	}

	[Token(Token = "0x6012C8C")]
	[Address(RVA = "0x28A2D60", Offset = "0x28A2D60", VA = "0x28A2D60")]
	public void Init(int team_index, ulong user_id, string nick_name, IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x6012C8D")]
	[Address(RVA = "0x28A30F0", Offset = "0x28A30F0", VA = "0x28A30F0")]
	private void OnMuteToggle()
	{
	}

	[Token(Token = "0x6012C8E")]
	[Address(RVA = "0x28A32A4", Offset = "0x28A32A4", VA = "0x28A32A4")]
	private void OnReortClick()
	{
	}

	[Token(Token = "0x6012C8F")]
	[Address(RVA = "0x28A35E0", Offset = "0x28A35E0", VA = "0x28A35E0")]
	private void OnMuteStateChange(object[] data)
	{
	}

	[Token(Token = "0x6012C90")]
	[Address(RVA = "0x28A377C", Offset = "0x28A377C", VA = "0x28A377C")]
	private void OnChannelResume(object[] data)
	{
	}

	[Token(Token = "0x6012C91")]
	[Address(RVA = "0x28A2C1C", Offset = "0x28A2C1C", VA = "0x28A2C1C")]
	private void RefreshView(bool isMute, bool isInit = false)
	{
	}
}
