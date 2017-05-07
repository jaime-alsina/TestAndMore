 Recruitment x

This is an asignment for 3 tasks:
Task 1 description:
	
	Write the method "Compress" which Task description:
	
	Refactor the Shape class to support the need of more shapes. You can make any change you see are needed in code or tests.

	See the tests for more information.

Code Requirements:

	1. All the test must pass.
	2. The code should fulfil OOP and SOLID principles.
	3. The code should be maintainable.
	  perform basic string compression using the counts of repeated characters. 
	If the compressed result is greater or equal to the input string then the it's an uncompressible string.
	
	See the tests for more information.


Code Requirements:

	1. All the test must pass.
	2. The algorithm should be efficient.
	3. The code should be maintainable.
  
  Task 2 
  Task description:
	
	Refactor the Shape class to support the need of more shapes. You can make any change you see are needed in code or tests.

	See the tests for more information.

Code Requirements:

	1. All the test must pass.
	2. The code should fulfil OOP and SOLID principles.
	3. The code should be maintainable.
	 
  Task 3
  

Task 3 description:
- is the original task
	-Write the domain model for a chat service. 

	-Designing a chat service is certainly far beyond the scope of what could be completed in a recruitment test. 
	-Please focus only in what is a fair representation of its model.

	Entities:

	 - Users
		User
			Id
			UserName
			Email
		Status
			UserId
			Status
			StatusMessage	
				
	 - Conversations
		Group
			GroupId
			GroupName
			OwnerUserId
			DateCreated
		GroupUserMap
			GroupId
			UserId
			DateCreated
		ActiveConversations
			Id
			ConversationType (group/private)
			Message
			MessageSent
			DateTimeCreated
		ActiveUser
			UserId
			ActiveConversationId
			MessageReceived
			DateTimeCreated
		
	 - Contacts
		Contact
			UserId
			TargetUserId
			TargetAccepted
			DateTimeCreated

	-Behaviour:

	 - Get user profile.

	 - Add contact request.

	 - Update status message (user is online, offline, custom message)

	 - Creating private and group conversations.

	 - Send messages to private and group conversations.
			

-Code requirements:

	-1. The code should fulfil OOP and SOLID principles.
	-2. The code should be maintainable.

-Hint:
	- This task evaluates desing & clean code over algorithmic. 
	- There is not exact correct answer. Feel free to add more Entities and/or Behaviour
