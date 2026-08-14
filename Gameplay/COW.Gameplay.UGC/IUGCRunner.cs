using Il2CppDummyDll;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000CA2")]
public interface IUGCRunner<T>
{
	[Token(Token = "0x600605D")]
	bool LoadRuntimeData(T runtimeData);

	[Token(Token = "0x600605E")]
	bool UnloadRuntimeData();
}
