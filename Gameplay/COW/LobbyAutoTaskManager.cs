using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DF8")]
public class LobbyAutoTaskManager : SingletonModule<LobbyAutoTaskManager>
{
	[Token(Token = "0x40119F6")]
	[FieldOffset(Offset = "0xC")]
	private AutoPopup m_LobbyAutoPopups;

	[Token(Token = "0x601343C")]
	[Address(RVA = "0xECACF0", Offset = "0xECACF0", VA = "0xECACF0")]
	public LobbyAutoTaskManager()
	{
	}

	[Token(Token = "0x601343D")]
	[Address(RVA = "0xECADA4", Offset = "0xECADA4", VA = "0xECADA4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601343E")]
	[Address(RVA = "0xECAE7C", Offset = "0xECAE7C", VA = "0xECAE7C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601343F")]
	[Address(RVA = "0xECAE04", Offset = "0xECAE04", VA = "0xECAE04")]
	public void Clear()
	{
	}

	[Token(Token = "0x6013440")]
	[Address(RVA = "0xECAED0", Offset = "0xECAED0", VA = "0xECAED0")]
	public void AddTask(AutoPopupTask task)
	{
	}

	[Token(Token = "0x6013441")]
	[Address(RVA = "0xECAF54", Offset = "0xECAF54", VA = "0xECAF54")]
	public void StartTask()
	{
	}

	[Token(Token = "0x6013442")]
	[Address(RVA = "0xECAFCC", Offset = "0xECAFCC", VA = "0xECAFCC")]
	public void StopTask()
	{
	}

	[Token(Token = "0x6013443")]
	[Address(RVA = "0xECB044", Offset = "0xECB044", VA = "0xECB044")]
	public void Update()
	{
	}
}
