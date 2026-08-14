using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002C46")]
public class UIHUDWereWolvesPlayerResultItem : MonoBehaviour
{
	[Token(Token = "0x4010E26")]
	[FieldOffset(Offset = "0xC")]
	public UILabel IndexLabel;

	[Token(Token = "0x4010E27")]
	[FieldOffset(Offset = "0x10")]
	public UISprite IndexBg;

	[Token(Token = "0x4010E28")]
	[FieldOffset(Offset = "0x14")]
	public UISprite PetIcon;

	[Token(Token = "0x4010E29")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NameLabel;

	[Token(Token = "0x4010E2A")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite KillOrTaskSprite;

	[Token(Token = "0x4010E2B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel KillOrTaskCount;

	[Token(Token = "0x4010E2C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject OtherPlayerRoot;

	[Token(Token = "0x4010E2D")]
	[FieldOffset(Offset = "0x28")]
	public UIButton AddFriendeBtn;

	[Token(Token = "0x4010E2E")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite AddFriendSprite;

	[Token(Token = "0x4010E2F")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ThumbUPBtn;

	[Token(Token = "0x4010E30")]
	[FieldOffset(Offset = "0x34")]
	public UISprite ThumbUPSprite;

	[Token(Token = "0x4010E31")]
	[FieldOffset(Offset = "0x38")]
	public GameObject IsDeadRoot;

	[Token(Token = "0x4010E32")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SelfColorBg;

	[Token(Token = "0x4010E33")]
	[FieldOffset(Offset = "0x40")]
	public UISprite IconBg1;

	[Token(Token = "0x4010E34")]
	[FieldOffset(Offset = "0x44")]
	public UISprite IconBg2;

	[Token(Token = "0x4010E35")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Mic;

	[Token(Token = "0x4010E36")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsInited;

	[Token(Token = "0x4010E37")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_UserID;

	[Token(Token = "0x4010E38")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsThumbUP;

	[Token(Token = "0x1700132B")]
	public bool IsThumbUp
	{
		[Token(Token = "0x601278E")]
		[Address(RVA = "0x1483368", Offset = "0x1483368", VA = "0x1483368")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601278D")]
	[Address(RVA = "0x1483360", Offset = "0x1483360", VA = "0x1483360")]
	public UIHUDWereWolvesPlayerResultItem()
	{
	}

	[Token(Token = "0x601278F")]
	[Address(RVA = "0x1483370", Offset = "0x1483370", VA = "0x1483370")]
	public void InitShowData(ulong userID, IHAAMHPPLMG playerID, string nickName, int roleColorIndex, bool isDead, bool isWolf, int taskOrKillCount)
	{
	}

	[Token(Token = "0x6012790")]
	[Address(RVA = "0x1483B54", Offset = "0x1483B54", VA = "0x1483B54")]
	private void SetFriendBtnState()
	{
	}

	[Token(Token = "0x6012791")]
	[Address(RVA = "0x148389C", Offset = "0x148389C", VA = "0x148389C")]
	private void SetPetIcon(int colorIndex)
	{
	}

	[Token(Token = "0x6012792")]
	[Address(RVA = "0x1483D58", Offset = "0x1483D58", VA = "0x1483D58")]
	private void OnAddFriend()
	{
	}

	[Token(Token = "0x6012793")]
	[Address(RVA = "0x1483EF4", Offset = "0x1483EF4", VA = "0x1483EF4")]
	private void OnThumbUp()
	{
	}

	[Token(Token = "0x6012794")]
	[Address(RVA = "0x1483D24", Offset = "0x1483D24", VA = "0x1483D24")]
	public void SetMicActive(bool isActive)
	{
	}
}
