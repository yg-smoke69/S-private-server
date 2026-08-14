using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F56")]
public class UIActivityContentController : UIBaseController
{
	[Token(Token = "0x6009B0B")]
	[Address(RVA = "0x2A009EC", Offset = "0x2A009EC", VA = "0x2A009EC")]
	public UIActivityContentController()
	{
	}

	[Token(Token = "0x6009B0C")]
	[Address(RVA = "0x2A01364", Offset = "0x2A01364", VA = "0x2A01364", Slot = "31")]
	public virtual void SetData(object data)
	{
	}

	[Token(Token = "0x6009B0D")]
	[Address(RVA = "0x2A01304", Offset = "0x2A01304", VA = "0x2A01304", Slot = "32")]
	public virtual void Reload()
	{
	}

	[Token(Token = "0x6009B0E")]
	[Address(RVA = "0x2A0E450", Offset = "0x2A0E450", VA = "0x2A0E450")]
	public void SetTime(ActivityGroupDesc groupDesc, UILabel time)
	{
	}

	[Token(Token = "0x6009B0F")]
	[Address(RVA = "0x2A0E5A0", Offset = "0x2A0E5A0", VA = "0x2A0E5A0")]
	public bool SetProgressBar(ActivityGroupDesc groupDesc, UILabel tips, UIProgressBar progressBar)
	{
		return default(bool);
	}

	[Token(Token = "0x6009B10")]
	[Address(RVA = "0x2A0E924", Offset = "0x2A0E924", VA = "0x2A0E924", Slot = "33")]
	public virtual void OnPopUpWindowListChange(bool isCovered)
	{
	}

	[Token(Token = "0x6009B11")]
	[Address(RVA = "0x2A0E980", Offset = "0x2A0E980", VA = "0x2A0E980", Slot = "34")]
	public virtual void OnVisibilityChange(bool isVisible, bool needRefresh)
	{
	}

	[Token(Token = "0x6009B12")]
	[Address(RVA = "0x2A0E9F0", Offset = "0x2A0E9F0", VA = "0x2A0E9F0", Slot = "35")]
	public virtual ResourceID GetBackGroundResroucesID()
	{
		return default(ResourceID);
	}
}
