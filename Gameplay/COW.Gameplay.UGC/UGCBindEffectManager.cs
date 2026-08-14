using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C37")]
public class UGCBindEffectManager : MonoBehaviour
{
	[Token(Token = "0x40064BF")]
	[FieldOffset(Offset = "0x0")]
	private static UGCBindEffectManager m_sIntances;

	[Token(Token = "0x40064C0")]
	[FieldOffset(Offset = "0xC")]
	private UIPanel _IconParentPanel;

	[Token(Token = "0x40064C1")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, GameObject> EntityMap;

	[Token(Token = "0x170007F9")]
	public static UGCBindEffectManager Instance
	{
		[Token(Token = "0x6005D4C")]
		[Address(RVA = "0x2F5A8E8", Offset = "0x2F5A8E8", VA = "0x2F5A8E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007FA")]
	private UIPanel IconParentPanel
	{
		[Token(Token = "0x6005D4D")]
		[Address(RVA = "0x2F5AAFC", Offset = "0x2F5AAFC", VA = "0x2F5AAFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005D4B")]
	[Address(RVA = "0x2F5A85C", Offset = "0x2F5A85C", VA = "0x2F5A85C")]
	public UGCBindEffectManager()
	{
	}

	[Token(Token = "0x6005D4E")]
	[Address(RVA = "0x2F5AC3C", Offset = "0x2F5AC3C", VA = "0x2F5AC3C")]
	public void AddIcon(long viewer, string resName, long bindEntityID, Vector3 localOrWorldPosition, Color32 color, float scale, string strParam)
	{
	}

	[Token(Token = "0x6005D4F")]
	[Address(RVA = "0x2F5B1DC", Offset = "0x2F5B1DC", VA = "0x2F5B1DC")]
	private GameObject GetEntityGameObject(long entityID)
	{
		return null;
	}

	[Token(Token = "0x6005D50")]
	[Address(RVA = "0x2F5B258", Offset = "0x2F5B258", VA = "0x2F5B258")]
	public void Init()
	{
	}

	[Token(Token = "0x6005D51")]
	[Address(RVA = "0x2F5B3EC", Offset = "0x2F5B3EC", VA = "0x2F5B3EC")]
	public void Uninit()
	{
	}

	[Token(Token = "0x6005D52")]
	[Address(RVA = "0x2F5B440", Offset = "0x2F5B440", VA = "0x2F5B440")]
	private void OnRemoveEntity(FONLAPPBCOO entityType, string entityID)
	{
	}

	[Token(Token = "0x6005D53")]
	[Address(RVA = "0x2F5B608", Offset = "0x2F5B608", VA = "0x2F5B608")]
	private void OnAddEntity(FONLAPPBCOO entityType, string entityID)
	{
	}
}
