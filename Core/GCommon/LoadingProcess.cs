using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003EC7")]
public class LoadingProcess
{
	[Token(Token = "0x2003EC8")]
	public enum EProcessStatus
	{
		[Token(Token = "0x401A844")]
		NotStarted,
		[Token(Token = "0x401A845")]
		Running,
		[Token(Token = "0x401A846")]
		Finished,
		[Token(Token = "0x401A847")]
		Exception
	}

	[Token(Token = "0x401A842")]
	[FieldOffset(Offset = "0x8")]
	private EProcessStatus m_Status;

	[Token(Token = "0x60198E5")]
	[Address(RVA = "0x32BD068", Offset = "0x32BD068", VA = "0x32BD068")]
	public LoadingProcess()
	{
	}

	[Token(Token = "0x60198E6")]
	[Address(RVA = "0x32BD070", Offset = "0x32BD070", VA = "0x32BD070")]
	public void StartProcess()
	{
	}

	[Token(Token = "0x60198E7")]
	[Address(RVA = "0x32BD094", Offset = "0x32BD094", VA = "0x32BD094")]
	public void UpdateProcess()
	{
	}

	[Token(Token = "0x60198E8")]
	[Address(RVA = "0x32BD0C8", Offset = "0x32BD0C8", VA = "0x32BD0C8")]
	public void CleanProcess()
	{
	}

	[Token(Token = "0x60198E9")]
	[Address(RVA = "0x32BD0E4", Offset = "0x32BD0E4", VA = "0x32BD0E4", Slot = "4")]
	public virtual bool IsMainProcess()
	{
		return default(bool);
	}

	[Token(Token = "0x60198EA")]
	[Address(RVA = "0x32BD0EC", Offset = "0x32BD0EC", VA = "0x32BD0EC")]
	public bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x60198EB")]
	[Address(RVA = "0x32BD100", Offset = "0x32BD100", VA = "0x32BD100")]
	public bool HasException()
	{
		return default(bool);
	}

	[Token(Token = "0x60198EC")]
	[Address(RVA = "0x32BD114", Offset = "0x32BD114", VA = "0x32BD114", Slot = "5")]
	protected virtual void OnStartProcess()
	{
	}

	[Token(Token = "0x60198ED")]
	[Address(RVA = "0x32BD118", Offset = "0x32BD118", VA = "0x32BD118", Slot = "6")]
	protected virtual EProcessStatus OnUpdateProcess()
	{
		return default(EProcessStatus);
	}

	[Token(Token = "0x60198EE")]
	[Address(RVA = "0x32BD120", Offset = "0x32BD120", VA = "0x32BD120", Slot = "7")]
	protected virtual void OnCleanProcess()
	{
	}
}
