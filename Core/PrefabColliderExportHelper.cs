using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003FC2")]
public class PrefabColliderExportHelper : MonoBehaviour
{
	[Token(Token = "0x401AD54")]
	[FieldOffset(Offset = "0xC")]
	public string ResourdIDName;

	[Token(Token = "0x401AD55")]
	[FieldOffset(Offset = "0x10")]
	public Collider[] ExportColliders;

	[Token(Token = "0x401AD56")]
	[FieldOffset(Offset = "0x14")]
	public Transform[] m_RefPositionTrans;

	[Token(Token = "0x6019F48")]
	[Address(RVA = "0x1E28834", Offset = "0x1E28834", VA = "0x1E28834")]
	public PrefabColliderExportHelper()
	{
	}
}
