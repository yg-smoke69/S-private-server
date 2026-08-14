using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200219C")]
internal class UIHudLudoPlayerFinishedInfoController : UIBaseController
{
	[Token(Token = "0x400D297")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLudoPlayerFinishedInfoView m_View;

	[Token(Token = "0x400D298")]
	[FieldOffset(Offset = "0x2C")]
	private int m_TotalPlayerCnt;

	[Token(Token = "0x400D299")]
	[FieldOffset(Offset = "0x30")]
	private int m_FinishedPlayerCnt;

	[Token(Token = "0x600B287")]
	[Address(RVA = "0xFF68A8", Offset = "0xFF68A8", VA = "0xFF68A8")]
	public UIHudLudoPlayerFinishedInfoController()
	{
	}

	[Token(Token = "0x600B288")]
	[Address(RVA = "0xFF692C", Offset = "0xFF692C", VA = "0xFF692C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B289")]
	[Address(RVA = "0xFF69D0", Offset = "0xFF69D0", VA = "0xFF69D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B28A")]
	[Address(RVA = "0xFF6BF0", Offset = "0xFF6BF0", VA = "0xFF6BF0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600B28B")]
	[Address(RVA = "0xFF6C54", Offset = "0xFF6C54", VA = "0xFF6C54", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B28C")]
	[Address(RVA = "0xFF6CB8", Offset = "0xFF6CB8", VA = "0xFF6CB8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B28D")]
	[Address(RVA = "0xFF6FD0", Offset = "0xFF6FD0", VA = "0xFF6FD0")]
	private void OnLudoPlayerFinished(object[] data)
	{
	}

	[Token(Token = "0x600B28E")]
	[Address(RVA = "0xFF7148", Offset = "0xFF7148", VA = "0xFF7148")]
	private void OnLudoPlayeChessFinished(object[] data)
	{
	}

	[Token(Token = "0x600B28F")]
	[Address(RVA = "0xFF73FC", Offset = "0xFF73FC", VA = "0xFF73FC")]
	private void OnAddLudoPlayer(object[] data)
	{
	}

	[Token(Token = "0x600B290")]
	[Address(RVA = "0xFF7798", Offset = "0xFF7798", VA = "0xFF7798")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B291")]
	[Address(RVA = "0xFF77A0", Offset = "0xFF77A0", VA = "0xFF77A0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600B292")]
	[Address(RVA = "0xFF77A8", Offset = "0xFF77A8", VA = "0xFF77A8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600B293")]
	[Address(RVA = "0xFF77B0", Offset = "0xFF77B0", VA = "0xFF77B0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
