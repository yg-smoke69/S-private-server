using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022B2")]
internal class UIHudPVEBossHPController : UIBaseController
{
	[Token(Token = "0x400D90E")]
	private const int CONST_HPMaxLayerNum = 5;

	[Token(Token = "0x400D90F")]
	[FieldOffset(Offset = "0x28")]
	private int m_CurHPLayerIndex;

	[Token(Token = "0x400D910")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudPVEBossHPView m_View;

	[Token(Token = "0x600BEC9")]
	[Address(RVA = "0x18399F0", Offset = "0x18399F0", VA = "0x18399F0")]
	public UIHudPVEBossHPController()
	{
	}

	[Token(Token = "0x600BECA")]
	[Address(RVA = "0x1839A7C", Offset = "0x1839A7C", VA = "0x1839A7C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BECB")]
	[Address(RVA = "0x1839B20", Offset = "0x1839B20", VA = "0x1839B20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BECC")]
	[Address(RVA = "0x1839DE0", Offset = "0x1839DE0", VA = "0x1839DE0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BECD")]
	[Address(RVA = "0x183A04C", Offset = "0x183A04C", VA = "0x183A04C")]
	private void OnBossSpawn(object[] data)
	{
	}

	[Token(Token = "0x600BECE")]
	[Address(RVA = "0x183A11C", Offset = "0x183A11C", VA = "0x183A11C")]
	private void OnBossDead(object[] data)
	{
	}

	[Token(Token = "0x600BECF")]
	[Address(RVA = "0x183A1EC", Offset = "0x183A1EC", VA = "0x183A1EC")]
	private void OnBossHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600BED0")]
	[Address(RVA = "0x183A49C", Offset = "0x183A49C", VA = "0x183A49C")]
	private void CheckHPLayerChange(int preLayerIndex, int curLayerIndex)
	{
	}

	[Token(Token = "0x600BED1")]
	[Address(RVA = "0x183A82C", Offset = "0x183A82C", VA = "0x183A82C")]
	private void OnBossColorChanged(object[] data)
	{
	}

	[Token(Token = "0x600BED2")]
	[Address(RVA = "0x183A888", Offset = "0x183A888", VA = "0x183A888")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BED3")]
	[Address(RVA = "0x183A890", Offset = "0x183A890", VA = "0x183A890")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
