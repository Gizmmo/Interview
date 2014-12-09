using UnityEngine;
using System.Collections;

public class ConversationManager {

	private static ConversationManager instance = new ConversationManager();
	
	// make sure the constructor is private, so it can only be instantiated here
	private ConversationManager() {}
	
	public static ConversationManager Instance {
		get { return instance; }
	}
}