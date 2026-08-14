using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C9B")]
internal class UGCMapRunner : _Attribute
{
	[Token(Token = "0x4006737")]
	[FieldOffset(Offset = "0x8")]
	private KEPDHPAAHGP m_OwnerGame;

	[Token(Token = "0x600603B")]
	[Address(RVA = "0x258A404", Offset = "0x258A404", VA = "0x258A404")]
	public UGCMapRunner(KEPDHPAAHGP ownerGame)
	{
	}

	[Token(Token = "0x600603C")]
	[Address(RVA = "0x258A424", Offset = "0x258A424", VA = "0x258A424", Slot = "4")]
	public bool LoadRuntimeData(HEAABFEMIDG runtimeData)
	{
		return default(bool);
	}

	[Token(Token = "0x600603D")]
	[Address(RVA = "0x258A568", Offset = "0x258A568", VA = "0x258A568", Slot = "5")]
	public bool UnloadRuntimeData()
	{
		return default(bool);
	}
}
