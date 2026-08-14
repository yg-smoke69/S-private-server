using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004121")]
public abstract class UIBaseModel
{
	[Token(Token = "0x401B5B0")]
	[FieldOffset(Offset = "0x0")]
	public static bool ObserverCheck;

	[Token(Token = "0x401B5B1")]
	[FieldOffset(Offset = "0x1")]
	public static bool SceneChangeCalledInLoadAndRun;

	[Token(Token = "0x401B5B2")]
	[FieldOffset(Offset = "0x2")]
	public static bool SceneChangeRemoveUIObserver;

	[Token(Token = "0x401B5B3")]
	[FieldOffset(Offset = "0x8")]
	private List<IUIModelDataChangeObserver> m_Observers;

	[Token(Token = "0x601A9A9")]
	[Address(RVA = "0x2C94C84", Offset = "0x2C94C84", VA = "0x2C94C84")]
	protected UIBaseModel()
	{
	}

	[Token(Token = "0x601A9AA")]
	[Address(RVA = "0x2C94C8C", Offset = "0x2C94C8C", VA = "0x2C94C8C", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x601A9AB")]
	[Address(RVA = "0x2C94C90", Offset = "0x2C94C90", VA = "0x2C94C90")]
	public void PrintObservers()
	{
	}

	[Token(Token = "0x601A9AC")]
	[Address(RVA = "0x2C92CA4", Offset = "0x2C92CA4", VA = "0x2C92CA4")]
	public void RegisterDataChangedNotification(IUIModelDataChangeObserver observer)
	{
	}

	[Token(Token = "0x601A9AD")]
	[Address(RVA = "0x2C93108", Offset = "0x2C93108", VA = "0x2C93108")]
	public void UnRegisterDataChangedNotification(IUIModelDataChangeObserver observer)
	{
	}

	[Token(Token = "0x601A9AE")]
	[Address(RVA = "0x2C95064", Offset = "0x2C95064", VA = "0x2C95064", Slot = "5")]
	public virtual void NotifyDataChanged(uint propID, object[] param)
	{
	}

	[Token(Token = "0x601A9AF")]
	public abstract uint GetModelType();

	[Token(Token = "0x601A9B0")]
	[Address(RVA = "0x2C953F4", Offset = "0x2C953F4", VA = "0x2C953F4", Slot = "7")]
	public virtual void LoginOffline()
	{
	}

	[Token(Token = "0x601A9B1")]
	[Address(RVA = "0x2C953F8", Offset = "0x2C953F8", VA = "0x2C953F8", Slot = "8")]
	public virtual void Login(object[] data)
	{
	}

	[Token(Token = "0x601A9B2")]
	[Address(RVA = "0x2C953FC", Offset = "0x2C953FC", VA = "0x2C953FC", Slot = "9")]
	public virtual void Logout(object[] data)
	{
	}

	[Token(Token = "0x601A9B3")]
	[Address(RVA = "0x2C95400", Offset = "0x2C95400", VA = "0x2C95400", Slot = "10")]
	public virtual void SceneChange(object[] data)
	{
	}

	[Token(Token = "0x601A9B4")]
	[Address(RVA = "0x2C95590", Offset = "0x2C95590", VA = "0x2C95590")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x601A9B5")]
	[Address(RVA = "0x2C955A8", Offset = "0x2C955A8", VA = "0x2C955A8", Slot = "11")]
	protected virtual void OnCleanup()
	{
	}

	[Token(Token = "0x601A9B6")]
	[Address(RVA = "0x2C955AC", Offset = "0x2C955AC", VA = "0x2C955AC", Slot = "12")]
	protected virtual void OnSceneChange(object[] data)
	{
	}

	[Token(Token = "0x601A9B7")]
	[Address(RVA = "0x2C955B0", Offset = "0x2C955B0", VA = "0x2C955B0", Slot = "13")]
	public virtual void ClearCache()
	{
	}
}
