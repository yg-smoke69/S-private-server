using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200219A")]
public class UIHUDLudoGamePlayerHeadInfoController : UIBaseController
{
	[Token(Token = "0x400D28D")]
	[FieldOffset(Offset = "0x28")]
	public LudoPlayerHeadPos curPos;

	[Token(Token = "0x400D28E")]
	[FieldOffset(Offset = "0x2C")]
	public uint playerID;

	[Token(Token = "0x400D28F")]
	[FieldOffset(Offset = "0x30")]
	private float m_EndTime;

	[Token(Token = "0x400D290")]
	[FieldOffset(Offset = "0x34")]
	private float m_LastSecond;

	[Token(Token = "0x400D291")]
	[FieldOffset(Offset = "0x38")]
	private float m_ProcessTimeLength;

	[Token(Token = "0x400D292")]
	[FieldOffset(Offset = "0x3C")]
	private UIHUDLudoPlayerHeadInfoView m_View;

	[Token(Token = "0x400D293")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsInTrust;

	[Token(Token = "0x400D294")]
	[FieldOffset(Offset = "0x44")]
	private int m_LastLeftTimeCeil;

	[Token(Token = "0x400D295")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsNeedUpdateOneSecond;

	[Token(Token = "0x600B271")]
	[Address(RVA = "0x167F014", Offset = "0x167F014", VA = "0x167F014")]
	public UIHUDLudoGamePlayerHeadInfoController()
	{
	}

	[Token(Token = "0x600B272")]
	[Address(RVA = "0x167F098", Offset = "0x167F098", VA = "0x167F098")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B273")]
	[Address(RVA = "0x167F13C", Offset = "0x167F13C", VA = "0x167F13C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B274")]
	[Address(RVA = "0x167DA50", Offset = "0x167DA50", VA = "0x167DA50")]
	public void ShowState(MDMMGPMJHJG state)
	{
	}

	[Token(Token = "0x600B275")]
	[Address(RVA = "0x167D8C4", Offset = "0x167D8C4", VA = "0x167D8C4")]
	public void UpdatePlayerState(IHDGEDLCEHF state)
	{
	}

	[Token(Token = "0x600B276")]
	[Address(RVA = "0x167CC6C", Offset = "0x167CC6C", VA = "0x167CC6C")]
	public void ShowHead(uint headPic)
	{
	}

	[Token(Token = "0x600B277")]
	[Address(RVA = "0x167DBF4", Offset = "0x167DBF4", VA = "0x167DBF4")]
	public void ShowTime(float endTime)
	{
	}

	[Token(Token = "0x600B278")]
	[Address(RVA = "0x167DDD8", Offset = "0x167DDD8", VA = "0x167DDD8")]
	public void OnLocalPlayerRoundChange(bool isLocalRound)
	{
	}

	[Token(Token = "0x600B279")]
	[Address(RVA = "0x167C944", Offset = "0x167C944", VA = "0x167C944")]
	public void UpdateHeadPos()
	{
	}

	[Token(Token = "0x600B27A")]
	[Address(RVA = "0x167C604", Offset = "0x167C604", VA = "0x167C604")]
	public void InitBaseInfo(uint chessType, bool isLocalPlayer)
	{
	}

	[Token(Token = "0x600B27B")]
	[Address(RVA = "0x167F250", Offset = "0x167F250", VA = "0x167F250")]
	private void Update()
	{
	}

	[Token(Token = "0x600B27C")]
	[Address(RVA = "0x167F2B8", Offset = "0x167F2B8", VA = "0x167F2B8")]
	private void UpdateSpriteProcess()
	{
	}

	[Token(Token = "0x600B27D")]
	[Address(RVA = "0x167F4E0", Offset = "0x167F4E0", VA = "0x167F4E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
