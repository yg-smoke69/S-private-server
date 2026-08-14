using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004120")]
public interface IUIModelDataChangeObserver
{
	[Token(Token = "0x601A9A7")]
	void OnDataChanged(UIBaseModel model, uint propID, object[] param);

	[Token(Token = "0x601A9A8")]
	uint GetInterestedPropID(UIBaseModel model);
}
