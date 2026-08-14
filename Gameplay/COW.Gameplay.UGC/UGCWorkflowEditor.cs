using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000CF0")]
public class UGCWorkflowEditor : _Attribute
{
	[Token(Token = "0x6006210")]
	[Address(RVA = "0x258F31C", Offset = "0x258F31C", VA = "0x258F31C")]
	public UGCWorkflowEditor()
	{
	}

	[Token(Token = "0x6006211")]
	[Address(RVA = "0x258F324", Offset = "0x258F324", VA = "0x258F324", Slot = "4")]
	public bool LoadProject(byte[] projectDataBytes, [Optional] EditorEntityData editorEntityData)
	{
		return default(bool);
	}

	[Token(Token = "0x6006212")]
	[Address(RVA = "0x258F3A0", Offset = "0x258F3A0", VA = "0x258F3A0", Slot = "5")]
	public bool UnloadProject()
	{
		return default(bool);
	}

	[Token(Token = "0x6006213")]
	[Address(RVA = "0x258F3F8", Offset = "0x258F3F8", VA = "0x258F3F8", Slot = "6")]
	public bool Export(out byte[] projectDataBytes, out HMHKAANAOPE runtimeData, ref EditorMiscData miscData)
	{
		return default(bool);
	}
}
