using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200415A")]
internal class UIModelManager : SingletonModule<UIModelManager>
{
	[Token(Token = "0x401B6B4")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, UIBaseModel> m_UIModels;

	[Token(Token = "0x401B6B5")]
	[FieldOffset(Offset = "0x10")]
	private List<UIBaseModel> m_ModelLists;

	[Token(Token = "0x601AB21")]
	[Address(RVA = "0x2CA7BB0", Offset = "0x2CA7BB0", VA = "0x2CA7BB0")]
	public UIModelManager()
	{
	}

	[Token(Token = "0x601AB22")]
	public T GetModel<T>() where T : UIBaseModel, new()
	{
		return null;
	}

	[Token(Token = "0x601AB23")]
	[Address(RVA = "0x2CA7C40", Offset = "0x2CA7C40", VA = "0x2CA7C40", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601AB24")]
	[Address(RVA = "0x2CA7C44", Offset = "0x2CA7C44", VA = "0x2CA7C44", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601AB25")]
	[Address(RVA = "0x2CA808C", Offset = "0x2CA808C", VA = "0x2CA808C")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x601AB26")]
	[Address(RVA = "0x2CA83AC", Offset = "0x2CA83AC", VA = "0x2CA83AC")]
	public void LoginOffline()
	{
	}

	[Token(Token = "0x601AB27")]
	[Address(RVA = "0x2CA86C0", Offset = "0x2CA86C0", VA = "0x2CA86C0")]
	public void UserLogin(object[] data)
	{
	}

	[Token(Token = "0x601AB28")]
	[Address(RVA = "0x2CA89DC", Offset = "0x2CA89DC", VA = "0x2CA89DC")]
	public void UserLogout(object[] data)
	{
	}

	[Token(Token = "0x601AB29")]
	[Address(RVA = "0x2CA8CF8", Offset = "0x2CA8CF8", VA = "0x2CA8CF8")]
	public void SceneChange(object[] data)
	{
	}

	[Token(Token = "0x601AB2A")]
	[Address(RVA = "0x2CA7F78", Offset = "0x2CA7F78", VA = "0x2CA7F78")]
	private IEnumerable<UIBaseModel> GetModels()
	{
		return null;
	}

	[Token(Token = "0x601AB2B")]
	[Address(RVA = "0x2CA9014", Offset = "0x2CA9014", VA = "0x2CA9014")]
	public void PrintObservers()
	{
	}
}
