export interface TaskItemUpdateDTO {
  title: string;
  description?: string;
  userId: string;
  tagId?: string;
  isCompleted: boolean;
}
