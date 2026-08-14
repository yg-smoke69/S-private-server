using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C9A")]
internal class UGCMapEditor : _Attribute
{
	[Token(Token = "0x4006735")]
	[FieldOffset(Offset = "0x8")]
	private JPPGAJBAAKK m_OwnerGame;

	[Token(Token = "0x4006736")]
	[FieldOffset(Offset = "0xC")]
	private EditorEntityData m_sharedEntityData;

	[Token(Token = "0x6006037")]
	[Address(RVA = "0x25894F8", Offset = "0x25894F8", VA = "0x25894F8")]
	public UGCMapEditor(JPPGAJBAAKK ownerGame)
	{
	}

	[Token(Token = "0x6006038")]
	[Address(RVA = "0x2589518", Offset = "0x2589518", VA = "0x2589518", Slot = "4")]
	public bool LoadProject(byte[] projectDataBytes, EditorEntityData editorEntityData)
	{
		return default(bool);
	}

	[Token(Token = "0x6006039")]
	[Address(RVA = "0x2589D54", Offset = "0x2589D54", VA = "0x2589D54", Slot = "5")]
	public bool UnloadProject()
	{
		return default(bool);
	}

	[Token(Token = "0x600603A")]
	[Address(RVA = "0x2589DAC", Offset = "0x2589DAC", VA = "0x2589DAC", Slot = "6")]
	public bool Export(out byte[] projectDataBytes, out HEAABFEMIDG runtimeData, ref EditorMiscData miscData)
	{
		return default(bool);
	}
}
