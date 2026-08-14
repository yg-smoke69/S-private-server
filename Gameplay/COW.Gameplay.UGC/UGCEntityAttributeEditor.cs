using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C3D")]
public class UGCEntityAttributeEditor : _Attribute
{
	[Token(Token = "0x170007FC")]
	private UGCCustomEntityAttributeManager m_CustomEntityManager
	{
		[Token(Token = "0x6005D86")]
		[Address(RVA = "0x2582DCC", Offset = "0x2582DCC", VA = "0x2582DCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005D85")]
	[Address(RVA = "0x2582DC4", Offset = "0x2582DC4", VA = "0x2582DC4")]
	public UGCEntityAttributeEditor()
	{
	}

	[Token(Token = "0x6005D87")]
	[Address(RVA = "0x2582EA0", Offset = "0x2582EA0", VA = "0x2582EA0", Slot = "4")]
	public bool LoadProject(byte[] projectDataBytes, [Optional] EditorEntityData editorEntityData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D88")]
	[Address(RVA = "0x2583008", Offset = "0x2583008", VA = "0x2583008", Slot = "5")]
	public bool UnloadProject()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D89")]
	[Address(RVA = "0x2583110", Offset = "0x2583110", VA = "0x2583110", Slot = "6")]
	public bool Export(out byte[] projectDataBytes, out List<CEIJKFCIALJ> runtimeData, ref EditorMiscData miscData)
	{
		return default(bool);
	}
}
