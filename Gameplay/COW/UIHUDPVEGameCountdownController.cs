using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022B6")]
public class UIHUDPVEGameCountdownController : UIBaseController
{
	[Token(Token = "0x400D91D")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDPVEGameCountdownView m_View;

	[Token(Token = "0x400D91E")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_GameEndTimeMS;

	[Token(Token = "0x400D91F")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsEndTimeCome;

	[Token(Token = "0x400D920")]
	[FieldOffset(Offset = "0x34")]
	private uint mSeconds;

	[Token(Token = "0x400D921")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder m_Timer;

	[Token(Token = "0x600BEEC")]
	[Address(RVA = "0x16816D0", Offset = "0x16816D0", VA = "0x16816D0")]
	public UIHUDPVEGameCountdownController()
	{
	}

	[Token(Token = "0x600BEED")]
	[Address(RVA = "0x1681754", Offset = "0x1681754", VA = "0x1681754")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BEEE")]
	[Address(RVA = "0x16817FC", Offset = "0x16817FC", VA = "0x16817FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BEEF")]
	[Address(RVA = "0x1681970", Offset = "0x1681970", VA = "0x1681970", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BEF0")]
	[Address(RVA = "0x1681AA4", Offset = "0x1681AA4", VA = "0x1681AA4")]
	private void OnEndTimeCome(object[] data)
	{
	}

	[Token(Token = "0x600BEF1")]
	[Address(RVA = "0x1681B9C", Offset = "0x1681B9C", VA = "0x1681B9C")]
	private void Update()
	{
	}

	[Token(Token = "0x600BEF2")]
	[Address(RVA = "0x1681E78", Offset = "0x1681E78", VA = "0x1681E78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BEF3")]
	[Address(RVA = "0x1681E80", Offset = "0x1681E80", VA = "0x1681E80")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
