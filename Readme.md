# Zonit.Plugins

## Overview

**Zonit.Plugins** is a modular .NET library designed to provide abstractions and event definitions for managing articles within a system. It enables developers to track, respond to, and integrate with various changes and actions related to articles, such as creation, updates, publication, and permission changes. The library is built with extensibility in mind, making it suitable for plugin-based architectures or systems requiring event-driven workflows.

## Available Events

The following events are defined in the library:

- **ArticleCreatedEvent**  
  Triggered when a new article is created. Contains the article's unique identifier and optional references to organization, project, or user.

- **ArticleDraftUpdatedEvent**  
  Triggered when an article draft is updated. Includes the article ID, updated content, and optionally the user who made the change.

- **ArticlePublishedEvent**  
  Triggered when an article is published. Contains the article ID and its published content.

- **ArticlePublishedAtUpdated**  
  Triggered when the publication date and time of an article is updated. Contains the article ID and the new publication timestamp.

- **ArticleExpiredAtUpdatedEvent**  
  Triggered when the expiration date of an article is updated. Contains the article ID and the new expiration date.

- **ArticleStatusUpdatedEvent**  
  Triggered when the status of an article is updated. Contains the article ID and the new status.

- **ArticleTitleUpdatedEvent**  
  Triggered when the title of an article is updated. Contains the article ID and the new title.

- **ArticleCultureUpdatedEvent**  
  Triggered when the culture (e.g., language or locale) of an article is updated. Contains the article ID and the new culture.

- **ArticleFlagsUpdatedEvent**  
  Triggered when the flags associated with an article are updated. Contains the article ID.

- **ArticlePermissionUpdatedEvent**  
  Triggered when the permissions for an article are updated. Contains the article ID and the new permission value.

- **ArticleDescriptionUpdatedEvent**  
  Wywo³ywany, gdy opis artyku³u zostaje zaktualizowany. Zawiera identyfikator artyku³u oraz nowy opis.