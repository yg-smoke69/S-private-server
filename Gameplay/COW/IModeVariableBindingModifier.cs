using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E72")]
public interface IModeVariableBindingModifier
{
	[Token(Token = "0x6013686")]
	bool FromJsonData(ModeVariables contextVariables, JsonData jsonData);
}
