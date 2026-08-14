using COW.UGCHudEdit;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002412")]
public abstract class UIUGCHudWidgetAttributeBaseController : UIBaseController
{
	[Token(Token = "0x400E0C1")]
	[FieldOffset(Offset = "0x28")]
	protected RecordUGCHudWidgetAttributeCommand m_RecordCommand;

	[Token(Token = "0x170010FA")]
	public abstract object AttributeObject
	{
		[Token(Token = "0x600CBC3")]
		get;
		[Token(Token = "0x600CBC4")]
		set;
	}

	[Token(Token = "0x600CBC1")]
	[Address(RVA = "0x2FF3E0C", Offset = "0x2FF3E0C", VA = "0x2FF3E0C")]
	protected UIUGCHudWidgetAttributeBaseController()
	{
	}

	[Token(Token = "0x600CBC2")]
	protected abstract UIUGCHudWidgetAttributeEnum GetAttributeEnum();

	[Token(Token = "0x600CBC5")]
	public abstract void SetAttributeDirty();

	[Token(Token = "0x600CBC6")]
	[Address(RVA = "0x2FF3E90", Offset = "0x2FF3E90", VA = "0x2FF3E90", Slot = "35")]
	public virtual void InitDepth(int startDepth)
	{
	}

	[Token(Token = "0x600CBC7")]
	[Address(RVA = "0x2FF4030", Offset = "0x2FF4030", VA = "0x2FF4030")]
	protected void StartRecordCommand()
	{
	}

	[Token(Token = "0x600CBC8")]
	[Address(RVA = "0x2FF41B0", Offset = "0x2FF41B0", VA = "0x2FF41B0")]
	protected void EndRecordCommand()
	{
	}
}
