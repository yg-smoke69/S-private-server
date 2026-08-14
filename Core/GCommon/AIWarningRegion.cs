using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20005A4")]
public class AIWarningRegion<T> : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4004357")]
	[FieldOffset(Offset = "0x0")]
	protected T MyParam;

	[Token(Token = "0x4004358")]
	[FieldOffset(Offset = "0x0")]
	private Player m_InPlayer;

	[Token(Token = "0x6002251")]
	public AIWarningRegion()
	{
	}

	[Token(Token = "0x6002252")]
	public void InitParam(T initParam)
	{
	}

	[Token(Token = "0x6002253")]
	public virtual void OnInit()
	{
	}

	[Token(Token = "0x6002254")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[Token(Token = "0x6002255")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002256")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002257")]
	public void OnRecycle()
	{
	}

	[Token(Token = "0x6002258")]
	private Transform GCommon_002EIAIWarningRegion_002Eget_transform()
	{
		return null;
	}
}
